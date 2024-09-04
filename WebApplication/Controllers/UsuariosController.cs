using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PT_SIxDegrees.Api.Business.Service;
using PT_SIxDegrees.Api.DataAccess.Data;

namespace PT_SIxDegrees.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioConfigurationBusiness _usuarioConfigurationBusiness;

        public UsuariosController(UsuarioConfigurationBusiness usuarioConfigurationBusiness)
        {
            _usuarioConfigurationBusiness = usuarioConfigurationBusiness;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var response =  _usuarioConfigurationBusiness.GetAllUsers();

            if(!response.Success)
            {
                return NotFound();
            }
            else
            {
                return Ok(response);
            }
        }       

    }
}
