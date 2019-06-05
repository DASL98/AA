using System.ComponentModel.DataAnnotations;
namespace ADOPTAAHORA.Models
{
    public class Pet
    {

        public int id { get; set; }

        [Required]
        public string NombreMascota { get; set; }

        [Required]
        public int Peso { get; set; }

        [Required]
        public int CodigoMascota { get; set; }
       
        [Required]
        public int Edad { get; set; }

        [Required]
        public string Foto { get; set; }

    }
}