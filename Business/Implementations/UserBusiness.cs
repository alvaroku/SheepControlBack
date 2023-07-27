
using AutoMapper;
using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities;
using Entities.DTOs;

namespace Business.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        UserRepository _Repository { get; set; }
        public UserBusiness(SheepControlDbContext context)
        {

            _Repository = new UserRepository(context);

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

                response.Data = Mapper.Map<UserResponse>(newUser);
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

            u.ModificationDate = DateTime.Now;
            u.Name = request.Name;
            u.BirthDate = request.BirthDate;
            u.LastName = request.LastName;
            u.PhoneNumber = request.PhoneNumber;
            u.Password = request.Password;
            u.Email = request.Email;

            _Repository.Update(u);

            response.Data = Mapper.Map<UserResponse>(u);

            return response;
        }
        public Response<ProfileResponse> Update(int id, ProfileRequest request)
        {
            Response<ProfileResponse> response = new Response<ProfileResponse>();

            User u = _Repository.GetById(id);

            u.ModificationDate = DateTime.Now;
            u.Name = request.Name;
            u.BirthDate = request.BirthDate;
            u.LastName = request.LastName;
            u.PhoneNumber = request.PhoneNumber;
            u.Email = request.Email;
            u.Photo = request.Photo;
            _Repository.Update(u);

            response.Data = Mapper.Map<ProfileResponse>(u);

            return response;
        }
        public Response<bool> Delete(int id)
        {

            Response<bool> response = new Response<bool>();
            User u = _Repository.GetById(id);
            _Repository.Delete(u);
            return response;
        }
        public Response<bool> ToggleActive(int id)
        {
            Response<bool> response = new Response<bool>();

            var data = _Repository.GetById(id);
            data.Active = !data.Active;
            _Repository.Update(data);
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

                string body = @"
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset='UTF-8'>
        <title>Sheep Control</title>
    </head>
<style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            padding: 20px;
        }

        h1 {
            color: #333333;
        }

        p {
            color: #666666;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #007bff;
            color: #ffffff;
            text-decoration: none;
            border-radius: 4px;
        }
    </style>
    <body>
        <h1>¡Hola! {name}</h1>
        <p>Haz solicitado la recuperación de tu contraseña.</p>
        <p>Tu contraseña es: {password}</p>
<a href=""https://testersite-a8be1.web.app/login.html"" class=""button"">Iniciar sesión</a>
    </body>
    </html>
";
                body = body.Replace("{name}",data.Name);
                body = body.Replace("{password}", data.Password);
                Utils.EmailSender.SendEmail(data.Email, body, "Recuperación de contraseña");
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
    }
}
