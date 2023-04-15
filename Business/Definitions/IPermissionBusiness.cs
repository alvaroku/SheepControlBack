using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IPermissionBusiness
    {
        public Response<PermissionResponse> Create(PermissionRequest permissionRequest);
        public IEnumerable<PermissionResponse> Read();
    }
}
