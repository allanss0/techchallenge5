using System.ComponentModel.DataAnnotations;

namespace Techchallenge5.Models
{
    
    public class Carro
    {
        
        [Required]
        public string Modelo { get; set; }

        [Required]
  public string Name { get; set; } = string.Empty;  
        public string Cor  { get; set; }

        [Required]
        public int Ano { get; set; }
    }
}
