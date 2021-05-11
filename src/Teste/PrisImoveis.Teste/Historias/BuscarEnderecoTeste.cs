using PrisImoveis.Historias.ApiClients;
using PrisImoveis.Teste.Moks;
using System.Threading.Tasks;
using Xunit;

namespace PrisImoveis.Teste.Historias
{
   
    public class BuscarEnderecoTeste
    {
        [Fact]
        public async Task DeveBuscarEndereco()
        {
            //Arrage
            string cep = "76810164";
            var endereco = ModelAndDtoMocks.EnderecoDtoMock();
            var apiViaCep = new ApiClientMock().Buscar();

            //Action
            var buscarEnderecoPeloCep = new BuscarEndereco(apiViaCep);
            var resultado = await buscarEnderecoPeloCep.Executar(cep);

            //Assert
            Assert.NotNull(resultado);
            Assert.True(resultado.Cep == endereco.Cep);
        }

    }
}
