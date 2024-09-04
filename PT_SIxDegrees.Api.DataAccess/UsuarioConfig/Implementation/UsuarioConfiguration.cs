using Microsoft.EntityFrameworkCore;
using PT_SIxDegrees.Api.DataAccess.Data;
using PT_SIxDegrees.Api.DataAccess.UsuarioConfig.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_SIxDegrees.Api.DataAccess.UsuarioConfig.Implementation
{
    public class UsuarioConfiguration : IUsuarioConfiguration
    {
        private readonly UsuarioDbContext _entities;

        public UsuarioConfiguration(UsuarioDbContext entities)
        {
            _entities = entities;
        }

        
        public Task<bool> CreateUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario>GetAllUsers()
        {
            var usuarios = _entities.Usuarios.ToList();
            return usuarios;
        }

        public Task<bool> UpdateUsuario(Usuario usuario, int id)
        {
            throw new NotImplementedException();
        }
    }
}
