using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicio;

namespace API_Licencia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenciaController : ControllerBase
    {
        ILicenciaServicio _LicenciaServicio;
        
        public LicenciaController(ILicenciaServicio licenciaServicio)
        {
            _LicenciaServicio = licenciaServicio;
        }

        [HttpPost]
        public IActionResult RegistrarLicencia(Entidad.Licencia licencia)
        {
            _LicenciaServicio.RegistrarLicencia(licencia);
            return Ok();
        }

        [HttpGet]
        public IActionResult ObtenerLicencias()
        {
            var licencias = _LicenciaServicio.ObtenerLicencias();
            return Ok(licencias);

        }
    }
}
