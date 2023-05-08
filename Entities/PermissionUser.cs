using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PermissionUser:ObjetoBase
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int PermissionId { get; set; }
        public Permission Permission { get; set; }

    }
}
