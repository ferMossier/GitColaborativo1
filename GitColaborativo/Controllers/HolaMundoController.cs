using Microsoft.AspNetCore.Mvc;

namespace GitColaborativo.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class HolaMundoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetHolaMundo( string nombre )
        {
            return Ok( new { data = $"Hola Mundo, soy {nombre}" } );
        }
    }
}
