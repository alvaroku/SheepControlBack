using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PermissionUserRequest:ObjetoBase
    {
        public int UserId { get; set; }
        public int PermissionId { get; set; }
    }
    public class PermissionUserResponse:ObjetoBase
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
    }
}
