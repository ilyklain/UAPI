namespace UsuariosAPI.DTOs
{
    /// <summary>
    /// representa los datos del usuario
    /// </summary>
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }
    }
}