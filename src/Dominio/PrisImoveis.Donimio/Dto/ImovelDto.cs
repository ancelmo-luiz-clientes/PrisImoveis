using PrisImoveis.Donimio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrisImoveis.Donimio.Dto
{
    public class ImovelDto
    {
       
        public int Id { get; set; }
        public ETipoDeImovel TipoDeImovel { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
