using AA.Models;
using Microsoft.EntityFrameworkCore;

namespace AA.Datos
{
    public class MascotaContext: DbContext
    {
        public MascotaContext(DbContextOptions<MascotaContext> options) : base(options) {}
    
        public DbSet<Mascota> Mascotas{ get; set; }

        public DbSet<TipoMascota> Tipos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<TipoMascota>().HasData(
                new TipoMascota {
                    Id = 1,
                    Nombre = "Perro"
                },

                new TipoMascota {
                    Id = 2,
                    Nombre = "Gato"
                },

                new TipoMascota {
                    Id = 3,
                    Nombre = "Tapir"
                }
            );
            
        }
    }
}