
using Business.Definitions;
using Business.Implementations;
using Business.Utils;
using DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.Xml;
using System.Text;
using Microsoft.AspNetCore.Hosting;
namespace SheepControlApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
 

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            //builder.Services.AddSwaggerGen();
            //para boton auth
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SheepControl", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Jwt Auth",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[]{}
                    }
                });
            });
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    ValidAudience = builder.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                };
            });//bearer

            builder.Services.AddDbContext<SheepControlDbContext>(
                //options => options.UseInMemoryDatabase("Test")
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"))
                );//bd

            builder.Services.AddScoped<IUserBusiness, UserBusiness>();//business
            builder.Services.AddScoped<IVaccineBusiness, VaccineBusiness>();
            builder.Services.AddScoped<IActionBusiness, ActionBusiness>();
            builder.Services.AddScoped<IControllerBusiness, ControllerBusiness>();
            builder.Services.AddScoped<ISheepBusiness, SheepBusiness>();
            builder.Services.AddScoped<IPermissionBusiness, PermissionBusiness>();
            builder.Services.AddScoped<IPermissionRoleBusiness, PermissionRoleBusiness>();
            builder.Services.AddScoped<IRoleBusiness,RoleBusiness>();
            builder.Services.AddScoped<IRoleUserBusiness, RoleUserBusiness>();
            builder.Services.AddScoped<IVaccineSheepBusiness, VaccineSheepBusiness>();
            builder.Services.AddScoped<IAuthenticationBusiness,AuthenticationBusiness>();

            AutoMapperConfiguration.Configure();

            
            // Add Cors for api access
            builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();//bearer

            app.UseAuthorization();

            // Enable Cors for api acces
            app.UseCors("MyPolicy");

            app.MapControllers();

            app.Run();
        }
    }
}