using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Repositories.Definitions;
using DataAccess.Repositories.Implementations;
using Entities;
using Entities.DTOs;
using Shared;

namespace Business.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        IEmailSender _EmailSender { get; set; }
        IUserRepository _Repository { get; set; }
        
        IFileManager _FileManager { get; set; }
        public UserBusiness(SheepControlDbContext context, IFileManager fileManager,IEmailSender emailSender,IUserRepository userRepository)
        {
            _Repository = userRepository;
            _EmailSender = emailSender;
            _FileManager = fileManager;
        }
        public async Task<Response<UserResponse>> Create(UserRequest userRequest)
        {
            Response<UserResponse> response = new Response<UserResponse>();

            try
            {
                if (await _Repository.Exists(x => x.Email.Equals(userRequest.Email)))
                {
                    throw new Exception("El correo ya se encuentra registrado.");
                }
                User newUser = Mapper.Map<User>(userRequest);

                string generatedPassword = Utilities.GenerateRandomPassword();

                newUser.Password = Utilities.CalcularHash(generatedPassword);
                newUser.CreationDate = DateTime.Now;
                newUser.ModificationDate = newUser.CreationDate;

                await _Repository.Add(newUser);

                response.Message = MessageConstants.CreateSuccesMessage;
                response.Data = Mapper.Map<UserResponse>(newUser);

                await SendEmailDataAccess(newUser.Name, newUser.Email, generatedPassword,
                    "Por este medio te proporcionamos tus datos de acceso para que puedas ingresar al sistema. Por seguridad se recomienda cambiar la contraseña lo más pronto posible.",
                    "Datos de acceso Sheep Control");
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.BadRequest;
            }

            return response;

        }
        public async Task<IEnumerable<UserResponse>> Read()
        {

            IEnumerable<User> respuesta = await _Repository.GetAll();

            IEnumerable<UserResponse> mapeo = Mapper.Map<IEnumerable<UserResponse>>(respuesta);

            return mapeo;
        }
        public async Task<Response<UserResponse>> Update(int id, UserRequest request)
        {
            Response<UserResponse> response = new Response<UserResponse>();
            try
            {
                if (await _Repository.Exists(x => x.Email.Equals(request.Email) && x.Id != id))
                {
                    throw new Exception("El correo ya se encuentra registrado.");
                }

                User u = await _Repository.GetById(id);

                bool changes = u.Email != request.Email;

                u.ModificationDate = DateTime.Now;
                u.Name = request.Name;
                u.BirthDate = request.BirthDate;
                u.LastName = request.LastName;
                u.PhoneNumber = request.PhoneNumber;
                u.Email = request.Email;

                await _Repository.Update(u);
                response.Message = MessageConstants.UpdateSuccesMessage;
                response.Data = Mapper.Map<UserResponse>(u);
                if (changes)
                {
                    await SendEmailEmailChanged(response.Data.Name, response.Data.Email, "El correo que usas para acceder a Sheep Control ha cambiado.", "Cambios datos de acceso Sheep Control");
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.BadRequest;
            }

            return response;

        }
        public async Task<Response<ProfileResponse>> Update(int id, ProfileRequest request)
        {
            Response<ProfileResponse> response = new Response<ProfileResponse>();

            User u = await _Repository.GetById(id);

            if (await _Repository.Exists(x => x.Email.Equals(request.Email) && x.Id != id))
            {
                throw new Exception("El correo ya se encuentra registrado.");
            }
            if (request.ImageFile != null)
            {
                if (!string.IsNullOrEmpty(request.Photo))
                {
                    _FileManager.DeleteFile(PathConstants.USERIMAGEPATH, request.Photo);
                }
                request.Photo = _FileManager.UploadImage(PathConstants.USERIMAGEPATH, request.ImageFile);
            }

            bool changes = u.Email != request.Email;

            u.ModificationDate = DateTime.Now;
            u.Name = request.Name;
            u.BirthDate = request.BirthDate;
            u.LastName = request.LastName;
            u.PhoneNumber = request.PhoneNumber;
            u.Email = request.Email;
            u.Photo = (string.IsNullOrEmpty(request.Photo) || request.Photo == "null") ? null : request.Photo;
            await _Repository.Update(u);
            response.Message = MessageConstants.UpdateSuccesMessage;
            response.Data = Mapper.Map<ProfileResponse>(u);

            if (changes)
            {
                await SendEmailEmailChanged(response.Data.Name, response.Data.Email, "El correo que usas para acceder a Sheep Control ha cambiado.", "Cambios datos de acceso Sheep Control");
            }

            return response;
        }
        public async Task<Response<bool>> ChangePassword(int id, ChangePasswordRequest request)
        {
            Response<bool> response = new Response<bool>();

            User u = await _Repository.GetById(id);
            if (!Utilities.VerificarHash(request.CurrentPassword, u.Password))
            {
                response.Success = false;
                response.Message = "La contraseña actual es distinta a la registrada.";
                response.StatusCode = (int)EnumStatusCode.BadRequest;
                return response;
            }
            bool changes = !Utilities.VerificarHash(request.NewPassword, u.Password);

            if (changes)
            {
                u.Password = Utilities.CalcularHash(request.NewPassword);
                await _Repository.Update(u);
                response.Message = "Contraseña actualizada.";
                await SendEmailDataAccess(u.Name, u.Email, request.NewPassword, "Hemos detectado cambios en tus datos de acceso, por lo que nuevamente te los propocionamos.", "Cambios datos de acceso Sheep Control");
            }
            else
            {
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.BadRequest;
                response.Message = "La contraseña actual es la misma que la nueva.";
            }


            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {

            Response<bool> response = new Response<bool>();
            User u = await _Repository.GetById(id);
            await _Repository.Delete(id);
            response.Message = MessageConstants.DeleteSuccesMessage;
            return response;
        }
        public async Task<Response<bool>> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = await _Repository.GetById(id);
            data.Active = !data.Active;
            await _Repository.Update(data);
            response.Message = data.Active ? MessageConstants.ActiveSuccesMessage : MessageConstants.InactiveSuccesMessage;
            response.Data = data.Active;
            return response;
        }
        public async Task<Response<string>> RecoveryPassword(string email)
        {
            Response<string> response = new Response<string>();

            try
            {
                User data = await _Repository.GetByEmail(email);

                if (data == null)
                {
                    response.StatusCode = (int)EnumStatusCode.BadRequest;
                    response.Message = "Correo no encontrado";
                    response.Success = false;
                    return response;
                }
                response.Message = "La contraseña se ha enviado al correo ingresado";

                string generatedPassword = Utilities.GenerateRandomPassword();

                data.Password = Utilities.CalcularHash(generatedPassword);

                await _Repository.Update(data);

                await SendEmailResetPassword(data.Name, data.Email, generatedPassword);
            }
            catch (Exception ex)
            {
                response.StatusCode = (int)EnumStatusCode.InternalServer;
                response.Message = ex.Message;
                response.Success = false;
                return response;
            }
            return response;
        }
        public async Task<FileStream> GetImage(string imageName)
        {
            return _FileManager.GetImage(PathConstants.USERIMAGEPATH, imageName);
        }

        public async Task SendEmailDataAccess(string name, string email, string password, string mensaje, string asunto)
        {
            string body = EmailTemplateConstants.plantillaEmailDataAccess;
            body = body.Replace("{name}", name);
            body = body.Replace("{email}", email);
            body = body.Replace("{password}", password);
            body = body.Replace("{message}", mensaje);
            await _EmailSender.SendEmail(email, body, asunto);
        }

        public async Task SendEmailEmailChanged(string name, string email, string mensaje, string asunto)
        {
            string body = EmailTemplateConstants.plantillaEmailChanged;
            body = body.Replace("{name}", name);
            body = body.Replace("{email}", email);
            body = body.Replace("{message}", mensaje);
            await _EmailSender.SendEmail(email, body, asunto);
        }

        public async Task SendEmailResetPassword(string name, string email, string password)
        {
            string body = EmailTemplateConstants.plantillaEmailRecoveryPassword;
            body = body.Replace("{name}", name);
            body = body.Replace("{password}", password);
            await _EmailSender.SendEmail(email, body, "Recuperación de contraseña");
        }
    }
}
