using Microsoft.AspNetCore.Mvc;
using Techchallenge5.Models;

namespace Techchallenge5.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class CarroController : ControllerBase
    {
        public static List<Carro> Carros = new List<Carro>();
        
        [HttpPost]
        public void AddCarro([FromBody] Carro carroobj)
        {
            Carros.Add(carroobj);
        }
       

    }
}
