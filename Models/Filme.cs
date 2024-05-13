using System.ComponentModel.DataAnnotations;

namespace Techchallenge5.Models;

public class Filme
{
    public int Id { get; set; }
    [Required(ErrorMessage = "O Titulo do Filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O genero é obrigatorio")]
    [MaxLength(50, ErrorMessage = "Quantidade de caracteres excedido")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duracao é obrigatoria")]
    [Range(40,600,ErrorMessage ="Intervalo de tempo invalido,-- minimo 40 e maximo 600  Monday, May 13, 2024 6:38:18 PM")]
    public int Duracao { get; set; }
}
