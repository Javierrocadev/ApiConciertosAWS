using ApiConciertosAWS.Data;
using ApiConciertosAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiConciertosAWS.Repositories
{
    public class RepositoryEventos
    {
        private ConciertosContext context;

        public RepositoryEventos(ConciertosContext context)
        {
            this.context = context;
        }


        public async Task<List<Categoriaevento>> GetCategoriasAsync()
        {
            return await this.context.Categoriaeventos.ToListAsync();
        }

        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }


        public async Task<List<Evento>> GetEventosCategoriaAsync(int idcategoria)
        {
            return await this.context.Eventos.Where(p => p.IdCategoria == idcategoria).ToListAsync();
        }


    }
}
