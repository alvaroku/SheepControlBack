using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProfileResponse:ObjetoBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }

    }
    public class ProfileRequest : ObjetoBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
    public class ChangePasswordRequest : ObjetoBase
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
