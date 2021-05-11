using PrisImoveis.Donimio.Entidades;
using PrisImoveis.WebApp.Models;
using System.Collections.Generic;

namespace PrisImoveis.WebApp.Factories
{
    public static class ImovelFactory
    {
        public static ImovelViewModel MapearImovelViewModel(Imovel imovel)
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

        public static Imovel MapearImovel(ImovelViewModel imovelViewModel)
        {
            var imovel = new Imovel(imovelViewModel.TipoDeImovel,
                imovelViewModel.Cep,
                imovelViewModel.Logradouro,
                imovelViewModel.Numero,
                imovelViewModel.Descricao,
                imovelViewModel.Valor);

            return imovel;

        }


        public static IEnumerable<ImovelViewModel> MapearListaImovelViewModel(IEnumerable<Imovel> imoveis)
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
