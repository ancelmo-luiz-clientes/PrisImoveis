using PrisImoveis.WebApp.Models;
using PrisImoveis.WebApp.Models.Dto;
using System.Collections.Generic;

namespace PrisImoveis.WebApp.Factories
{
    public class ImovelFactory
    {
        public static ImovelViewModel MapearImovelViewModel(ImovelDto imovel)
        {
            var imovelViewModel = new ImovelViewModel()
            {
                Id = imovel.Id,
                Cep = imovel.Cep,
                Logradouro = imovel.Logradouro,
                Numero = imovel.Numero,
                Descricao = imovel.Descricao,
                Valor = imovel.Valor
            };

            return imovelViewModel;
        }
        public static ImovelDto MapearImovel(ImovelViewModel imovelViewModel)
        {
            return new ImovelDto
            {
                Cep = imovelViewModel.Cep,
                Descricao = imovelViewModel.Descricao,
                Logradouro = imovelViewModel.Logradouro,
                Numero = imovelViewModel.Numero,
                TipoDeImovel = imovelViewModel.TipoDeImovel,
                Valor = imovelViewModel.Valor
            };
        }
        public static IEnumerable<ImovelViewModel> MapearListaImovelViewModel(IEnumerable<ImovelDto> imoveis)
        {
            var lista = new List<ImovelViewModel>();

            foreach (var item in imoveis)
            {
                lista.Add(MapearImovelViewModel(item));
            }
            return lista;
        }
    }
}
