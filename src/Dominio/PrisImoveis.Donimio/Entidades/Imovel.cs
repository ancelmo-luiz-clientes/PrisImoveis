using PrisImoveis.Donimio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrisImoveis.Donimio.Entidades
{
    public class Imovel
    {
        public Imovel(ETipoDeImovel tipoDeImovel, string cep, string logradouro, string numero, string descricao, decimal valor)
        {
            TipoDeImovel = tipoDeImovel;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Descricao = descricao;
            Valor = valor;
        }

        public int Id { get; private set; }
        public ETipoDeImovel TipoDeImovel { get; private set; }
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
    }
}
