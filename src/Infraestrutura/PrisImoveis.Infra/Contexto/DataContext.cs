using Microsoft.EntityFrameworkCore;
using PrisImoveis.Donimio.Entidades;
using PrisImoveis.Infra.Contexto.Maps;

namespace PrisImoveis.Infra.Contexto
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Imovel> Imoveis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ImovelMap());
        }
    }
}
