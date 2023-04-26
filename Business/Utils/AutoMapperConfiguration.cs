using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities;
using Entities.DTOs;

namespace Business.Utils
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                //mappers principales
                cfg.CreateMap<UserRequest, User>().ReverseMap();

                cfg.CreateMap<User, LoginResponse>().ReverseMap();
                
                

            });
        }
    }
}
