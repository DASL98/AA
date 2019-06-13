using System.ComponentModel.DataAnnotations;

namespace AA.Models
{
    public class Solicitud
    {
        public int id { get; set; }

       [Required]
        public string CodigoM { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }
       
        [Required]
        public string Correo { get; set; }

        [Required]
        public string Telefono { get; set; }

        
    }
}