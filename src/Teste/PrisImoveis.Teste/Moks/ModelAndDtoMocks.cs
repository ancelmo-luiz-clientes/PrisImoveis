using PrisImoveis.Donimio.Dto;
using PrisImoveis.WebApp.Models;
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

        public static ImovelViewModel ImovelDtoMock(EnderecoDto endereco)
        {
            var imovel = new ImovelViewModel
            {
                Cep = endereco.Cep,
                Logradouro = endereco.Logradouro,
                Numero = "1234",
                Descricao = "Casa com 4 quartos",
                TipoDeImovel = Donimio.Enums.ETipoDeImovel.Casa,
                Valor = 1000.00m
            };
            return imovel;
        }
    }
}
