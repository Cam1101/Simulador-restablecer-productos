using Microsoft.AspNetCore.Mvc;

namespace ReplenishmentSimulator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        [HttpPost]
        public IActionResult Proveedor()
        {
            // Simula la respuesta del sistema de reabastecimiento
            return Ok(new { message = "Se realizó correctamnete el reabastecimiento" });
        }
    }
}
