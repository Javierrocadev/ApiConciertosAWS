using ApiConciertosAWS.Models;
using ApiConciertosAWS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiConciertosAWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConciertosController : ControllerBase
    {
        private RepositoryEventos repo;

        public ConciertosController(RepositoryEventos repo)
        {
            this.repo = repo;
        }



        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Evento>>> GetEventos()
        {
            return await this.repo.GetEventosAsync();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Categoriaevento>>> GetCategorias()
        {
            return await this.repo.GetCategoriasAsync();
        }

        [HttpGet]
        [Route("[action]/{idcategoria}")]
        public async Task<ActionResult<List<Evento>>> Find(int idcategoria)
        {
            return await this.repo.GetEventosCategoriaAsync(idcategoria);
        }


    }
}
