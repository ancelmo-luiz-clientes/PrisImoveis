using PrisImoveis.Donimio.Entidades;
using PrisImoveis.Donimio.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrisImoveis.Donimio.IRepositories
{
    public interface IImovelRepository
    {
        Task Criar(Imovel imovel);

        Task Atualizar(Imovel imovel);

        Task Excluir(Imovel imovel);

        Task<Imovel> BuscarPorId(int id);

        Task<IEnumerable<Imovel>> ListarTodosImoveis();

        Task<IEnumerable<Imovel>> ListarPorTipoDeImovel(ETipoDeImovel tipoDeImovel);

    }
}
