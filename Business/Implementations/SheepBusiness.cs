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
    public class SheepBusiness:ISheepBusiness
    {
        SheepRepository _SheepRepository;
        public SheepBusiness(SheepControlDbContext context) { 
        
            _SheepRepository = new SheepRepository(context);
        }

        public Response<SheepResponse> Create(SheepRequest sheepRequest)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SheepResponse> Read()
        {
            throw new NotImplementedException();
        }
    }
}
