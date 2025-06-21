// Documentación: El contrato del servicio de usuarios

using UsuariosAPI.DTOs;

namespace UsuariosAPI.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioDto>> GetAllAsync();
        Task<UsuarioDto> GetByIdAsync(int id);
        Task<UsuarioDto> CreateAsync(UsuarioCreateDto usuarioCreateDto);
        Task<bool> UpdateAsync(int id, UsuarioUpdateDto usuarioUpdateDto);
        Task<bool> DeleteAsync(int id);
    }
} 