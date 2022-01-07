
using EntidadesDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APINexos.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var conexion = string.Format("Data Source=MSI;Initial Catalog=BDNexosPrueba;Integrated Security=True");
            options.UseSqlServer(conexion);

        }

        public DbSet<LibrsDTOIn> Autores { get; set; }
        public DbSet<LibrosDTO> Libros { get; set; }
        
    }
}
