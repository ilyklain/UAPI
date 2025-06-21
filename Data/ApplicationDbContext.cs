// Documentación: Este es el archivo que hace que se conecte a la db

using Microsoft.EntityFrameworkCore;
using UsuariosAPI.Models;

namespace UsuariosAPI.Data
{
/// <summary>
/// Este es el puente entre la aplicación y la db
/// </summary>
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

        /// <summary>
        /// Aqui se representa la tabla de los usuarios
        /// </summary>
        public DbSet<Usuario> Usuarios { get; set; }
        }
        } 