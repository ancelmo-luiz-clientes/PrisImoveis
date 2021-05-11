using PrisImoveis.Donimio.Dto;
using Refit;
using System.Threading.Tasks;

namespace PrisImoveis.Infra.ApiClients
{
    public interface IViaCep
    {
        [Get("/ws/{id}/json/")]
        Task<EnderecoDto> BuscarEnderecoPeloCep(string id);
    }
}
