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
    [Range(70,600,ErrorMessage ="Intervalo de tempo invalido,-- minimo 70 e maximo 600")]
    public int Duracao { get; set; }
}
