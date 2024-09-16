using ApiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRest.Context
{
    public class AppDbContext: DbContext
    {
        // El argumento configura el comportamiento del DbContext
        // Se llama al constructor de la clase DbContext y se le pasa el parámetro options
        // Base se emplea para llamar a una propiedad o función en la clase Base desde una clase derivada
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Concert> Concerts { get; set; }
    }
}
