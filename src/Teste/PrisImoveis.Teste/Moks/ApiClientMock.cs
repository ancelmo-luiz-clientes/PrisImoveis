using PrisImoveis.Infra.ApiClients;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

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
