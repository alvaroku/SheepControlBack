using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class EmailReponse
    {
        public string Email { get; set; }
    }
    public class EmailRequest
    {
        public string Token { get; set; }
    }
}
