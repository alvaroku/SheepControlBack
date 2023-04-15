using Business.Definitions;
using DataAccess;
using DataAccess.Implementations;
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
    }
}
