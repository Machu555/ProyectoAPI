using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDTO
{
    [Keyless]
    public class LibrsDTOIn
    {
        public string AutorNombre { get; set; }
        public DateTime FechaNacimiento { get; set; } = new DateTime();
        //[NotMapped]
        //public int Id { get; set; }
        public string Ciudad { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
