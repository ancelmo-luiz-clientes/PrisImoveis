using PrisImoveis.Donimio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrisImoveis.Donimio.Entidades
{
    public class Imovel
    {
        public Imovel(ETipoDeImovel tipoDeImovel, string descricao, decimal valor)
        {
            TipoDeImovel = tipoDeImovel;
            Descricao = descricao;
            Valor = valor;
        }

        public int Id { get; private set; }
        public ETipoDeImovel TipoDeImovel { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
    }
}
