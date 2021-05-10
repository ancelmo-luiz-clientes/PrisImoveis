using Microsoft.EntityFrameworkCore;
using PrisImoveis.Donimio.Entidades;
using PrisImoveis.Donimio.Enums;
using PrisImoveis.Donimio.IRepositories;
using PrisImoveis.Infra.Contexto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisImoveis.Infra.Repositories
{
    public class ImovelRepository : IImovelRepository
    {
        private readonly DataContext _dataContext;

        public ImovelRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task Criar(Imovel imovel)
        {
            _dataContext.Imoveis.Add(imovel);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Atualizar(Imovel imovel)
        {
            _dataContext.Update(imovel);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Excluir(Imovel imovel)
        {
            _dataContext.Remove(imovel);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<Imovel> BuscarPorId(int id)
        {
            var imovel = await _dataContext.Imoveis.FirstOrDefaultAsync(x => x.Id == id);

            return imovel;
        }
        public async Task<IEnumerable<Imovel>> ListarPorTipoDeImovel(ETipoDeImovel tipoDeImovel)
        {
            return await _dataContext.Imoveis.Where(i => i.TipoDeImovel == tipoDeImovel).AsNoTracking().ToListAsync();
        }
        public async Task<IEnumerable<Imovel>> ListarTodosImoveis()
        {
            return await _dataContext.Imoveis.AsNoTracking().ToListAsync();
        }
    }
}
