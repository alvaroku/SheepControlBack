using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PermissionRoleRequest:ObjetoBase
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
    }
    public class PermissionRoleCreateRequest
    {
        public int RoleId { get; set; }
        public int[] PermissionIds { get; set; }
    }
    public class PermissionRoleResponse:ObjetoBase
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
    }
}
