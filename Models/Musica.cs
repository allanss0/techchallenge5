using System.ComponentModel.DataAnnotations;

namespace Techchallenge5.Models
{
    public class Musica
    {
        public string NomeBanda { get; set; }
        public string Album { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
