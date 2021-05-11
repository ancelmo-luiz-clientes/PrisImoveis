using PrisImoveis.Donimio.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrisImoveis.Teste.Moks
{
    public static class ModelAndDtoMocks
    {

        public static EnderecoDto EnderecoDtoMock()
        {
            var endereco = new EnderecoDto
            {
                Cep = "76810-164",
                Logradouro = "Rua Secundária",
                Bairro = "Novo Horizonte",
                Localicade = "Porto Velho",
                Uf = "RO"
            };
            return endereco;
        }
    }
}
