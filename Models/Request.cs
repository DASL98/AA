using System.ComponentModel.DataAnnotations;
namespace ADOPTAAHORA.Models
{
    public class Request
    {

        public int id { get; set; }

       [Required]
        public int CodigoM { get; set; }

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