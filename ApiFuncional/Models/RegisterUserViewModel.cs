using System.ComponentModel.DataAnnotations;

namespace ApiFuncional.Models
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = " O campo {0} está em formato inválido.")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "O campo {0} deve conter entre {2} a {1} caracteres.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Compare("Password", ErrorMessage = "As senhas não conferem.")]
        public string? ConfirmPassword { get; set; }
    }
}
