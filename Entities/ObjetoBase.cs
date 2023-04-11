using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ObjetoBase
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool Active { get; set; }

    }
}
