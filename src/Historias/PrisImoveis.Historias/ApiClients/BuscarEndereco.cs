using PrisImoveis.Donimio.Dto;
using PrisImoveis.Infra.ApiClients;
using System.Threading.Tasks;

namespace PrisImoveis.Historias.ApiClients
{
    public class BuscarEndereco
    {
        private readonly IViaCep _viaCep;

        public BuscarEndereco(IViaCep viaCep)
        {
            _viaCep = viaCep;
        }

        public async Task<EnderecoDto> Executar(string id)
        {
            var endereco = await _viaCep.BuscarEnderecoPeloCep(id);

            return endereco;
        }

    }
}
