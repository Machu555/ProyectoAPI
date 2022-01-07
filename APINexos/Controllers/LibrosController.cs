using APINexos.Service;
using EntidadesDTO;
using EntidadesDTO.DTOINput;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APINexos.Controllers
{
    [Route("api/libros")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly ILibrosService _libroService;
        private readonly ILogger<LibrosDTO> _logger;

        public LibrosController(ILibrosService libroService, ILogger<LibrosDTO> logger)
        {
            _libroService = libroService;
            _logger = logger;
        }

        [HttpGet("listado")]
        public async Task<ActionResult<List<LibrosDTO>>> ListadoLibros()
        {
            var libros = await _libroService.ConsultarLibros();
            return Ok(libros);
        }

        [HttpPost("registroLibro")]
        public async Task<ActionResult> RegistrarLibro(LibroDTOIn libro)
        {

            var resultado = await _libroService.RegistrarLibro(libro);
            return Ok(resultado);
        }

        [HttpPost("listadoPalabraClave")]
        public async Task<ActionResult<List<LibrosDTO>>> ListadoLibrosPalabraClave(LibrosPalabraClaveDTOIn palabraClave)
        {
            var libros = await _libroService.ConsultarLibrospalabraClave(palabraClave);
            return Ok(libros);
        }

    }
}
