using APINexos.Context;
using EntidadesDTO;
using EntidadesDTO.DTOINput;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace APINexos.Service
{
    public class LibrosService : ILibrosService
    {
        DatabaseContext _dbContext = null;

        public LibrosService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<LibrosDTO>> ConsultarLibros()
        {
            var libros = await _dbContext.Libros.FromSqlRaw($"spLibro_ConsultarLibros").ToListAsync();
            return libros;
        }

        public async Task<List<LibrosDTO>> ConsultarLibrospalabraClave(LibrosPalabraClaveDTOIn palabraClave)
        {
            var libros = await _dbContext.Libros.FromSqlInterpolated($"spBusquedaPalabraClave {palabraClave.Caso}, {palabraClave.NombreAutor}, {palabraClave.TituloLibro}, {palabraClave.Anio}").ToListAsync();
            return libros;

        }

        public async Task<short> RegistrarLibro(LibroDTOIn libro)
        {

            var output = new SqlParameter();
            output.ParameterName = "@Resultado";
            output.SqlDbType = SqlDbType.SmallInt;
            output.Direction = ParameterDirection.Output;

           

            await _dbContext.Database.ExecuteSqlInterpolatedAsync($"spLibro_Insertar @Titulo= {libro.Titulo}, @Anio = {libro.Anio}, @Genero={libro.Genero}, @CantidadPaginas={libro.Paginas}, @AutorId={libro.AutorId}, @Resultado={output} OUT");

            var resultado = (short)output.Value;

            return resultado;
        }
    }
}
