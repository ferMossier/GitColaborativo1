using Microsoft.AspNetCore.Mvc;

namespace GitColaborativo.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class ChauMundoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetChauMundo( string name )
        {
            return Ok( new { data = $"Chau Mundo, soy {name} y me tengo que ir." } );
        }

    }
}
