using AA.Models;
using Microsoft.EntityFrameworkCore;

namespace AA.Datos
{
    public class MascotaContext: DbContext
    {
        public MascotaContext(DbContextOptions<MascotaContext> options) : base(options) {}
    
        public DbSet<Mascota> Mascotas{ get; set; }

        public DbSet<TipoMascota> Tipos { get; set;}

        
    }
}