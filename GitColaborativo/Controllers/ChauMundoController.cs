namespace GitColaborativo.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class ChauMundoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetChauMundo( string name )
        {
            //Comentario de prueba
            return Ok( new { data = $"Chau Mundo, soy {name} y me tengo que ir." } );
        }

    }
}
