// Documentación: DTO para cambiarle los datos a un usuario

using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.DTOs
{
    /// <summary>
    /// Al momento de cambiar un dato o varios se le pediran los siguientes datos
    /// </summary>
    public class UsuarioUpdateDto
    {
        [Required(ErrorMessage = "El nombre introducido no es valido!")]
        [StringLength(100, ErrorMessage = "El nombre supera el limite de caracteres!")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo no puede quedar vacio!")]
        [EmailAddress(ErrorMessage = "El correo no es valido!")]
        public string Correo { get; set; }

        [Range(1, 120, ErrorMessage = "La edad no es valida!")]
        public int Edad { get; set; }
    }
} 