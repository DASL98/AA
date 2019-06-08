using System.ComponentModel.DataAnnotations;
namespace AA.Models
{
    public class Mascota
    {
        public int Id { get; set;}

        [Required]
        public string NombreMascota { get; set;}

        [Required]
        public int Peso { get; set;}

        [Required]
        public string CodigoMascota { get; set;}
  
        public TipoMascota Tipo { get; set; }
        
        
        [Required]
        public int Edad { get; set;} 

        [Required]
        public string Foto { get; set;}

        public int TipoId { get; set; }

    }
}