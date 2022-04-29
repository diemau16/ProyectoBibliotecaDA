using Microsoft.EntityFrameworkCore;
using ProyectoBibliotecaDA.Datos.Modelo;

namespace ProyectoBibliotecaDA.Datos.Servicio
{
    public class RepositorioBiblioteca : DbContext
    {
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca> options) 
            :base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        
    }
}
