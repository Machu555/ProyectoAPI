using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDTO.DTOINput
{
    [Keyless]
    public class LibroDTOIn
    {     
        public string Titulo { get; set; }
        public int Anio { get; set; }
        public string Genero { get; set; }
        public int Paginas { get; set; }  
        public int AutorId { get; set; }
    }
}
