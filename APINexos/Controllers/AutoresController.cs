using APINexos.Service;
using EntidadesDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APINexos.Controllers
{
    [Route("api/autores")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly IAutoresService _autorService;
        private readonly ILogger<LibrsDTOIn> _logger;
        public AutoresController(IAutoresService autorService, ILogger<LibrsDTOIn> logger)
        {
            _logger = logger;
            _autorService = autorService;
        }

      
        [HttpGet("listado")]     
        public async Task<ActionResult<List<LibrsDTOIn>>> ListadoAutores()
        {
            var autores = await _autorService.ConsultarAutores();
            return Ok(autores);
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarAutor(LibrsDTOIn autor)
        {
            
            var resultado = await _autorService.RegistrarAutor(autor);
            return Ok(resultado);
        }

    }
}
