using PrisImoveis.WebApp.Models.Dto;
using Refit;
using System.Threading.Tasks;

namespace PrisImoveis.WebApp.ApiClients
{
    public interface IViaCep
    {
        [Get("/ws/{id}/json/")]
        Task<EnderecoDto> BuscarEnderecoPeloCep(string id);
    }
}
