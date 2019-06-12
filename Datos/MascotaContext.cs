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
            
            modelBuilder.Entity<Mascota>().HasData(
                new Mascota {
                    Id = 1,
                    NombreMascota = "Julito",
                    Peso = 1900,
                    CodigoMascota = "ACM2PL",
                    TipoId = 1,
                    Edad = 18,
                    Foto = "https://estaticos.muyinteresante.es/media/cache/760x570_thumb/uploads/images/article/5c3871215bafe83b078adbe3/perro.jpg"
                },
                    new Mascota {
                    Id = 2,
                    NombreMascota = "Ronina",
                    Peso = 800,
                    CodigoMascota = "RGM2PL",
                    TipoId = 1,
                    Edad = 5,
                    Foto = "https://mxcity.mx/wp-content/uploads/2017/08/1-9.jpg"
                },
                    new Mascota {
                    Id = 3,
                    NombreMascota = "Michi",
                    Peso = 250,
                    CodigoMascota = "GAT001",
                    TipoId = 2,
                    Edad = 2,
                    Foto = "https://www.notigatos.es/wp-content/uploads/2017/10/gatito-830x552.jpg"
                    },
                    new Mascota {
                    Id = 3,
                    NombreMascota = "Oliver",
                    Peso = 590,
                    CodigoMascota = "TAPIR590",
                    TipoId = 3,
                    Edad = 19,
                    Foto = "https://www.elpopular.pe/sites/default/files/styles/img_620x465/public/imagen/2019/03/22/Noticia-232947-youtube_tapir_590_sufre_estafa_con_sus_redes_sociales_y_hace_pedido_a_seguidores.png?itok=NeTL_yoG"
                    }
            );
        }
    }
}