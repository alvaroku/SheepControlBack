using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class ControllerBusiness:IControllerBusiness
    {
        ControllerRepository _ControllerRepository;
        public ControllerBusiness(SheepControlDbContext context)
        {
            _ControllerRepository = new ControllerRepository(context);
        }

        public Response<ControllerResponse> Create(ControllerRequest controllerRequest)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ControllerResponse> Read()
        {
            throw new NotImplementedException();
        }
    }
}
