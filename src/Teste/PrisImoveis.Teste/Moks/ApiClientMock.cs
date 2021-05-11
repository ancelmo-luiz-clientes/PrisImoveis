using PrisImoveis.Infra.ApiClients;
using Refit;

namespace PrisImoveis.Teste.Moks
{
    public class ApiClientMock
    {
        public IViaCep Buscar()
        {
            var apiClient = RestService.For<IViaCep>("https://viacep.com.br");
            return apiClient;
        }
    }
}
