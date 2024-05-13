using Microsoft.AspNetCore.Mvc;
using Techchallenge5.Models;

namespace Techchallenge5.Controllers
{
    [ApiController]
    [Route(template: "[Controller]")]
    public class MusicaController : ControllerBase
    {

        public static List<Musica> Musicas = new List<Musica>();
        [HttpPost]
        public void AdicionaMusica([FromBody] Musica musica)
        { 
        Musicas.Add(musica);
        }



    }
}
