using PrisImoveis.WebApp.Models.Dto;
using PrisImoveis.WebApp.Models.Enums;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrisImoveis.WebApp.ApiClients
{
    public interface IPrisImoveisApi
    {
        [Post("/api/imoveis/criar")]
        Task Criar(ImovelDto imovel);

        [Get("/api/imoveis/listar-todos")]
        Task<IEnumerable<ImovelDto>> ListarTodosImoveis();

        [Get("listar-por-tipo/{tipoImovel}")]
        Task<IEnumerable<ImovelDto>> ListarPorTipoDeImovel(ETipoDeImovel tipoDeImovel);
    }
}
