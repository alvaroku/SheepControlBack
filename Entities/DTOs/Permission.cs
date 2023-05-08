using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PermissionResponse : ObjetoBase
    {
        public string Description { get; set; }
        public string Clave { get; set; }

        public int ControllerId { get; set; }
        public Controller Controller { get; set; }

        public int ActionId { get; set; }
        public Action Action { get; set; }
    }
    public class PermissionRequest : ObjetoBase
    {
        public string Description { get; set; }
        public string Clave { get; set; }

        public int ControllerId { get; set; }

        public int ActionId { get; set; }
    }
}
