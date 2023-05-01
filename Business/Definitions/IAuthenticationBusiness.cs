using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Definitions
{
    public interface IAuthenticationBusiness
    {
        void Athenticar();
        void ValidarToken(string token);
        void VerifyRol();
        void VerifyPermission();
    }
}
