using System.ComponentModel.DataAnnotations;

namespace ApiFuncional.Models
{
    public class LoginUserViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = " O campo {0} está em formato inválido.")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "O campo {0} deve conter entre {2} a {1} caracteres.")]
        public string? Password { get; set; }
    }
}
