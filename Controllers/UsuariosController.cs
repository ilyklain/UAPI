// Documentación: Controlador de la API para las operaciones CRUD de Usuarios

using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.DTOs;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers
{
    /// <summary>
    /// Controlar las operaciones CRUD de usuarios
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        /// <summary>
        /// Obtiene una lista de todos los usuarios
        /// </summary>
        /// <returns>La lista de usuarios</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetUsuarios()
        {
            var usuarios = await _usuarioService.GetAllAsync();
            return Ok(usuarios);
        }

        /// <summary>
        /// Obtiene un usuario por su ID
        /// </summary>
        /// <param name="id">El ID del usuario que se le esta apuntando</param>
        /// <returns>El usuario solicitado</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UsuarioDto>> GetUsuario(int id)
        {
            var usuario = await _usuarioService.GetByIdAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="usuarioCreateDto">Los datos para crear el nuevo usuario</param>
        /// <returns>El usuario recien creado</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UsuarioDto>> PostUsuario(UsuarioCreateDto usuarioCreateDto)
        {
            var nuevoUsuario = await _usuarioService.CreateAsync(usuarioCreateDto);
            return CreatedAtAction(nameof(GetUsuario), new { id = nuevoUsuario.Id }, nuevoUsuario);
        }

        /// <summary>
        /// Actualiza un usuario existente
        /// </summary>
        /// <param name="id">El ID del usuario que se va a actualizar</param>
        /// <param name="usuarioUpdateDto">Los datos actualizados del ususuario</param>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutUsuario(int id, UsuarioUpdateDto usuarioUpdateDto)
        {
            var result = await _usuarioService.UpdateAsync(id, usuarioUpdateDto);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }

        /// <summary>
        /// Elimina un usuario
        /// </summary>
        /// <param name="id">El ID del usuario a eliminar</param>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var result = await _usuarioService.DeleteAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
} 