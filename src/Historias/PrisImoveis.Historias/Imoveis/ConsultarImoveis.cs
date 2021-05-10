using PrisImoveis.Donimio.Entidades;
using PrisImoveis.Donimio.Enums;
using PrisImoveis.Donimio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrisImoveis.Historias.Imoveis
{
    public class ConsultarImoveis
    {
        private readonly IImovelRepository _imovelRepository;

        public ConsultarImoveis(IImovelRepository imovelRepository)
        {
            _imovelRepository = imovelRepository;
        }

        public async Task<Imovel> BuscarPorId(int id)
        {
            return await _imovelRepository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Imovel>> ListarTodosImoveis()
        {
            var imoveis = await _imovelRepository.ListarTodosImoveis();

            return imoveis;
        }

        public async Task<IEnumerable<Imovel>> ListarPorTipoDeImovel(ETipoDeImovel tipoDeImovel)
        {
            var imoveis = await _imovelRepository.ListarPorTipoDeImovel(tipoDeImovel);

            return imoveis;
        }

    }
}
