using System.ComponentModel.DataAnnotations;

namespace Api.Domain
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(500, ErrorMessage = "Campo deve ter no máximo {1} caracteres")]
        [MinLength(3, ErrorMessage = "Campo deve ter, no mínimo, {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Idade obrigatória")]
        public int Idade { get; set; }
    }
}
