using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDTO
{
    [Keyless]
    public class LibrosDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public short Anio { get; set; }
        public string Genero { get; set; }
        public short Paginas { get; set; }
        public string NombreCompleto { get; set; }

    }
}
