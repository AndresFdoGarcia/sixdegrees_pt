using Azure;
using PT_SIxDegrees.Api.DataAccess.Data;
using PT_SIxDegrees.Api.DataAccess.UsuarioConfig.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_SIxDegrees.Api.Business.Service
{
    public class UsuarioConfigurationBusiness
    {
        private readonly IUsuarioConfiguration _usuarioConfiguration;

        public UsuarioConfigurationBusiness(IUsuarioConfiguration usuarioConfiguration)
        {
            _usuarioConfiguration = usuarioConfiguration;
        }

        public Response<List<Usuario>> GetAllUsers()
        {
            try
            {
                var usuarios = _usuarioConfiguration.GetAllUsers();
                return new Response<List<Usuario>>
                {
                    Success = true,
                    Data = usuarios
                };
            }
            catch (Exception ex)
            {
                return new Response<List<Usuario>>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }
    }

    public class Response<T>
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
        public T? Data { get; set; }
    }
}
