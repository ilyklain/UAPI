// Documentación: Representa a el usuario en la db

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsuariosAPI.Models
{
    /// <summary>
    /// Aqui se guardan los datos de el usuario en la db
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// La cedula del usuario, para no repetirla la proxima vez
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        [Required]
        public string Nombre { get; set; }

        /// <summary>
        /// El email para mandarle los correos. tiene que ser valido
        /// </summary>
        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        /// <summary>
        /// Años del usuario
        /// </summary>
        public int Edad { get; set; }
    }
} 