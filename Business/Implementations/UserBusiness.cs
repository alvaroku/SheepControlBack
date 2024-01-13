using AutoMapper;
using Business.Definitions;
using Business.Utils;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        UserRepository _Repository { get; set; }
        string ResourcePath = string.Empty;
        IFileManager _FileManager { get; set; }
        public UserBusiness(SheepControlDbContext context, IFileManager fileManager)
        {
            _Repository = new UserRepository(context);
            ResourcePath = Constants.USERIMAGEPATH;
            _FileManager = fileManager;
        }
        public Response<UserResponse> Create(UserRequest userRequest)
        {
            Response<UserResponse> response = new Response<UserResponse>();

            try
            {
                User newUser = Mapper.Map<User>(userRequest);
                newUser.CreationDate = DateTime.Now;
                newUser.ModificationDate = newUser.CreationDate;
                _Repository.Create(newUser);
                response.Message = Constants.CreateSuccesMessage;
                response.Data = Mapper.Map<UserResponse>(newUser);
                EmailSender.SendEmailDataAccess(newUser.Name, newUser.Email, newUser.Password, 
                    "Por este medio te proporcionamos tus datos de acceso para que puedas ingresar al sistema.", 
                    "Datos de acceso Sheep Control");
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.InternalServer;
            }

            return response;

        }
        public IEnumerable<UserResponse> Read()
        {

            var respuesta = _Repository.Read();

            var mapeo = Mapper.Map<IEnumerable<UserResponse>>(respuesta);

            return mapeo.ToList();
        }
        public Response<UserResponse> Update(int id, UserRequest request)
        {
            Response<UserResponse> response = new Response<UserResponse>();

            User u = _Repository.GetById(id);

            bool changes = (u.Email != request.Email || u.Password != request.Password) ? true : false;

            u.ModificationDate = DateTime.Now;
            u.Name = request.Name;
            u.BirthDate = request.BirthDate;
            u.LastName = request.LastName;
            u.PhoneNumber = request.PhoneNumber;
            u.Password = request.Password;
            u.Email = request.Email;

            _Repository.Update(u);
            response.Message = Constants.UpdateSuccesMessage;
            response.Data = Mapper.Map<UserResponse>(u);

            if (changes)
            {
                Utils.EmailSender.SendEmailDataAccess(response.Data.Name, response.Data.Email, response.Data.Password, "Hemos detectado cambios en tus datos de acceso, por lo que nuevamente te los propocionamos.", "Cambios datos de acceso Sheep Control");
            }

            return response;
        }
        public Response<ProfileResponse> Update(int id, ProfileRequest request)
        {
            Response<ProfileResponse> response = new Response<ProfileResponse>();

            User u = _Repository.GetById(id);

            if (request.ImageFile != null)
            {
                if (!string.IsNullOrEmpty(request.Photo))
                {
                    _FileManager.DeleteFile(ResourcePath, request.Photo);
                }
                request.Photo = _FileManager.UploadImage(ResourcePath, request.ImageFile);
            }

            bool changes = (u.Email != request.Email) ? true : false;

            u.ModificationDate = DateTime.Now;
            u.Name = request.Name;
            u.BirthDate = request.BirthDate;
            u.LastName = request.LastName;
            u.PhoneNumber = request.PhoneNumber;
            u.Email = request.Email;
            u.Photo = (string.IsNullOrEmpty(request.Photo) || request.Photo == "null") ? null : request.Photo;
            _Repository.Update(u);
            response.Message = Constants.UpdateSuccesMessage;
            response.Data = Mapper.Map<ProfileResponse>(u);

            if (changes)
            {
                Utils.EmailSender.SendEmailDataAccess(response.Data.Name, response.Data.Email, u.Password, "Hemos detectado cambios en tus datos de acceso, por lo que nuevamente te los propocionamos.", "Cambios datos de acceso Sheep Control");
            }

            return response;
        }
        public Response<bool> ChangePassword(int id, ChangePasswordRequest request)
        {
            Response<bool> response = new Response<bool>();

            User u = _Repository.GetById(id);
            if (u.Password != request.CurrentPassword)
            {
                response.Success = false;
                response.Message = "La contraseña actual es incorrecta.";
                response.StatusCode = (int)EnumStatusCode.BadRequest;
                return response;
            }
            bool changes = (u.Password != request.NewPassword) ? true : false;

            if (changes)
            {
                u.Password = request.NewPassword;
                _Repository.Update(u);
                response.Message = "Contraseña actualizada.";
                Utils.EmailSender.SendEmailDataAccess(u.Name, u.Email, u.Password, "Hemos detectado cambios en tus datos de acceso, por lo que nuevamente te los propocionamos.", "Cambios datos de acceso Sheep Control");
            }
            else
            {
                response.Success = false;
                response.StatusCode = (int)EnumStatusCode.BadRequest;
                response.Message = "La contraseña actual es la misma que la nueva.";
            }


            return response;
        }
        public Response<bool> Delete(int id)
        {

            Response<bool> response = new Response<bool>();
            User u = _Repository.GetById(id);
            _Repository.Delete(u);
            response.Message = Constants.DeleteSuccesMessage;
            return response;
        }
        public Response<bool> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = _Repository.GetById(id);
            data.Active = !data.Active;
            _Repository.Update(data);
            response.Message = data.Active ? Constants.ActiveSuccesMessage : Constants.InactiveSuccesMessage;
            response.Data = data.Active;
            return response;
        }
        public Response<string> RecoveryPassword(string email)
        {
            Response<string> response = new Response<string>();

            try
            {
                User data = _Repository.GetByEmail(email);

                if (data == null)
                {
                    response.StatusCode = (int)EnumStatusCode.BadRequest;
                    response.Message = "Correo no encontrado";
                    response.Success = false;
                    return response;
                }
                response.Message = "La contraseña se ha enviado al correo ingresado";

                Utils.EmailSender.SendEmailResetPassword(data.Name, data.Email, data.Password);
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
        public FileStream GetImage(string imageName)
        {
            return _FileManager.GetImage(ResourcePath, imageName);
        }
    }
}
