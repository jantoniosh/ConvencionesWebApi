using ConvencionesWebApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace ConvencionesWebApi.Controllers
{
    [Route("")]
    [ApiController]
    public class EntradaController : ControllerBase
    {
        private ConvencionesDBContext _dbContext;
        public EntradaController(ConvencionesDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        [HttpGet("GetEntradas")]
        public IActionResult GetEntradas()
        {
            try
            {
                var entradas = _dbContext.tblEntrada.ToList();
                if (entradas.Count == 0)
                {
                    return StatusCode(404, "No entradas found");
                }
                return Ok(entradas);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has ocurred");
            }
        }
        [HttpGet("GetPodcasts")]
        public IActionResult GetPodcasts(string Convencion)
        {
            try
            {
                if (Convencion == "*")
                {
                    var podcasts_gen = _dbContext.tblEntrada.Where(b => b.Categoria.Equals("Podcast")).ToList();
                    if (podcasts_gen.Count == 0)
                    {
                        return StatusCode(404, "No podcasts found");
                    }
                    return Ok(podcasts_gen);
                }
                else
                {
                    var podcasts = _dbContext.tblEntrada
                        .Where(b => b.Categoria.Equals("Podcast"))
                        .Where(b => b.Convencion.Equals(Convencion))
                        .ToList();
                    if (podcasts.Count == 0)
                    {
                        return StatusCode(404, "No podcasts found");
                    }
                    return Ok(podcasts);
                }

                
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has ocurred");
            }
        }
        
        [HttpGet("GetInfografias")]
        public IActionResult GetInfografias(string Convencion)
        {
            try
            {
                if (Convencion == "*")
                {
                    var infografias_gen = _dbContext.tblEntrada.Where(b => b.Categoria.Equals("Infografía")).ToList();
                    if (infografias_gen.Count == 0)
                    {
                        return StatusCode(404, "No infografías found");
                    }
                    return Ok(infografias_gen);
                }
                else
                {
                    var infografias = _dbContext.tblEntrada
                        .Where(b => b.Categoria.Equals("Infografía"))
                        .Where(b => b.Convencion.Equals(Convencion))
                        .ToList();
                    if (infografias.Count == 0)
                    {
                        return StatusCode(404, "No infografías found");
                    }
                    return Ok(infografias);
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has ocurred");
            }
        }
        [HttpGet("GetFichas")]
        public IActionResult GetFichas(string Convencion)
        {
            try
            {
                if (Convencion == "*")
                {
                    var infografias_gen = _dbContext.tblEntrada.Where(b => b.Categoria.Equals("Ficha")).ToList();
                    if (infografias_gen.Count == 0)
                    {
                        return StatusCode(404, "No Fichas found");
                    }
                    return Ok(infografias_gen);
                }
                else
                {
                    var infografias = _dbContext.tblEntrada
                        .Where(b => b.Categoria.Equals("Ficha"))
                        .Where(b => b.Convencion.Equals(Convencion))
                        .ToList();
                    if (infografias.Count == 0)
                    {
                        return StatusCode(404, "No Fichas found");
                    }
                    return Ok(infografias);
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has ocurred");
            }
        }

        [HttpGet("GetTitulo")]
        public IActionResult GetTitulo(string Titulo)
        {
            try
            {
                var entradas = _dbContext.tblEntrada.Where(b => b.Titulo.Contains(Titulo)).ToList();
                if (entradas.Count == 0)
                {
                    return StatusCode(404, "No podcast found");
                }
                return Ok(entradas);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has ocurred");
            }
        }
    }
}
