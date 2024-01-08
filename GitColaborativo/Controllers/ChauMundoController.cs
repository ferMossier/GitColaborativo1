using Microsoft.AspNetCore.Mvc;

namespace GitColaborativo.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class ChauMundoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetChauMundo()
        {
            return Ok( new { data = "Chau Mundo" } );
        }

    }
}
