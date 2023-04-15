using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IControllerBusiness
    {
        public Response<ControllerResponse> Create(ControllerRequest controllerRequest);
        public IEnumerable<ControllerResponse> Read();
    }
}
