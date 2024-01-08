namespace GitColaborativo.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class HolaMundoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetHolaMundo( string name )
        {
            return Ok( new { data = $"Hola Mundo, soy {name}" } );
        }
    }
}
