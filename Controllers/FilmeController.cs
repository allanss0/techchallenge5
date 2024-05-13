using Microsoft.AspNetCore.Mvc;
using Techchallenge5.Models;

namespace Techchallenge5.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController: ControllerBase
{
    public static List<Filme> Filmes = new List<Filme>();
    public static int id = 1;
    [HttpPost]
    public void AdicionaFilme([FromBody]Filme filme)
    {
        filme.Id = id ++;
        Filmes.Add(filme);
        
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperarFilmes([FromQuery]int skip = 0,[FromQuery] int take = 9 )
    {   
        return Filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]

    public Filme? FilmePorId(int id)
    {
        return  Filmes.FirstOrDefault(Filme => Filme.Id == id);
    }
}
