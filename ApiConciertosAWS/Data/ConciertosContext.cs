using ApiConciertosAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiConciertosAWS.Data
{
    public class ConciertosContext : DbContext
    {
        public ConciertosContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Categoriaevento> Categoriaeventos { get; set; }
        

    }
}
