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
   ´public class ActionBusiness:IActionBusiness
    {
        ActionRepository _ActionRepository;
        public ActionBusiness(SheepControlDbContext context) {
        
            _ActionRepository = new ActionRepository(context);
        }

        public Response<ActionResponse> Create(ActionRequest actionRequest)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ActionResponse> Read()
        {
            throw new NotImplementedException();
        }
    }
}
