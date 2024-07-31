using System.ComponentModel.DataAnnotations;

namespace ApiFuncional.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int QuantidadeEstoque { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(120, MinimumLength = 2, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres.")]
        public string? Descricao { get; set; }
    }
}
