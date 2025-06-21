// Documentación: DTO para la creacion de un usuario nuevo

using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.DTOs
{
    /// <summary>
    /// para crear un un usuario nuevo se necesita estos datos
    /// </summary>
    public class UsuarioCreateDto
    {
        [Required(ErrorMessage = "Falta el nombre!")]
        [StringLength(100, ErrorMessage = "El nombre es muy largo!")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Falta el correo!")]
        [EmailAddress(ErrorMessage = "El correo no cuenta con un formato valido!")]
        public string Correo { get; set; }

        [Range(1, 120, ErrorMessage = "Debes ingresar una edad valida!")]
        public int Edad { get; set; }
    }
} 