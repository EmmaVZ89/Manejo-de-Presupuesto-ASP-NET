using System.ComponentModel.DataAnnotations;

namespace Manejo_Presupuesto.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo es requerido")]
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Password { get; set; }
        public bool Recuerdame { get; set; }
    }
}
