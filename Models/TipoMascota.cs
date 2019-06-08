using System.Collections.Generic;

namespace AA.Models
{
    public class TipoMascota
    {
        public int Id{ get;set; }

        public string Nombre{ get; set;}
    
        public List<Mascota> Mascotas { get; set;}
    }
}