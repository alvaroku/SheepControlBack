using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IActionBusiness
    {
        public Response<ActionResponse> Create(ActionRequest actionRequest);
        public IEnumerable<ActionResponse> Read();
    }
}
