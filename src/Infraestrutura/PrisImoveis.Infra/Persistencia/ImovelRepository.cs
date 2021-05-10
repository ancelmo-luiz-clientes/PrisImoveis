using PrisImoveis.Donimio.Entidades;
using PrisImoveis.Donimio.Enums;
using PrisImoveis.Donimio.IRepositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrisImoveis.Infra.Repositories
{
    public class ImovelRepository : IImovelRepository
    {
        public Task Atualizar(Imovel imovel)
        {
            throw new NotImplementedException();
        }

        public Task<Imovel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task Criar(Imovel imovel)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(Imovel imovel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Imovel>> ListarPorTipoDeImovel(ETipoDeImovel tipoDeImovel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Imovel>> ListarTodosImoveis()
        {
            throw new NotImplementedException();
        }
    }
}
