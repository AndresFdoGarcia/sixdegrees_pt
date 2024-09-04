using PT_SIxDegrees.Api.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_SIxDegrees.Api.DataAccess.UsuarioConfig.Contract
{
    public interface IUsuarioConfiguration
    {
        List<Usuario>GetAllUsers();       

    }
}
