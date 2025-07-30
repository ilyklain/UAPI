// Documentación: El perfil del traductor de Usuarios

using AutoMapper;
using UsuariosAPI.DTOs;
using UsuariosAPI.Models;

namespace UsuariosAPI.Profiles
{
    /// <summary>
    /// De Usuario para DTO y viceversa
    /// Hola mundo.
    /// </summary>
    public class UsuariosProfile : Profile
    {
        public UsuariosProfile()
        {
            CreateMap<Usuario, UsuarioDto>();
            CreateMap<UsuarioCreateDto, Usuario>();
            CreateMap<UsuarioUpdateDto, Usuario>();
        }
    }
} 
