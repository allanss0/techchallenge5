using Microsoft.AspNetCore.Mvc;
using Techchallenge5.Models;

namespace Techchallenge5.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class CachorroController : ControllerBase
    {
        public static List<Cachorro> Cachorros = new List<Cachorro>();

        [HttpPost]
        public void AdicionaCachorro([FromBody] Cachorro objCachorro)
        { 
        Cachorros.Add(objCachorro);
        }

        
    }
}
