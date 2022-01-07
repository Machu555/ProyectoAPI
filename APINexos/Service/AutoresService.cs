using APINexos.Context;
using EntidadesDTO;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace APINexos.Service
{
    public class AutoresService : IAutoresService
    {
        DatabaseContext _dbContext = null;
        public AutoresService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<LibrsDTOIn>> ConsultarAutores()
        {
            var autores = await _dbContext.Autores.FromSqlRaw($"spAutor_ConsultarAutores").ToListAsync();
            return autores;
        }

        public async Task<int> RegistrarAutor(LibrsDTOIn autor)
        {
            var output = new SqlParameter();
            output.ParameterName = "@Resultado";
            output.SqlDbType = SqlDbType.Int;
            output.Direction = ParameterDirection.Output;

             await _dbContext.Database.ExecuteSqlInterpolatedAsync($"spAutor_Registrar {autor.AutorNombre}, {autor.FechaNacimiento}, {autor.Ciudad}, {autor.CorreoElectronico}, {output} OUT");


            return (int)output.Value;
        }
    }
}
