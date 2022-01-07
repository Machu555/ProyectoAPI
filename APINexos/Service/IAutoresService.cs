
using EntidadesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APINexos.Service
{
    public interface IAutoresService
    {
         Task<List<LibrsDTOIn>> ConsultarAutores();
         Task<int> RegistrarAutor(LibrsDTOIn autor);

            
    }
}
