using PrisImoveis.Teste.Moks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrisImoveis.Teste.Integracao
{
    public class BuscarEnderecoPorCepTeste
    {
        [Fact]
        public async Task DeveBuscarEnderecoPeloCep()
        {
            //Arrage
            string cep = "76810164";
            var apiViaCep = new ApiClientMock().Buscar();

            //Action
            var resultado = await apiViaCep.BuscarEnderecoPeloCep(cep);

            //Assert
            Assert.NotNull(resultado);
        }
    }
}
