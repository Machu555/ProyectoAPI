using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntidadesDTO;
using EntidadesDTO.DTOINput;

namespace APINexos.Service
{
    public  interface ILibrosService
    {
        Task<List<LibrosDTO>> ConsultarLibros();
        Task<short> RegistrarLibro(LibroDTOIn libro);

        Task<List<LibrosDTO>> ConsultarLibrospalabraClave(LibrosPalabraClaveDTOIn palabraClave);

    }
}
