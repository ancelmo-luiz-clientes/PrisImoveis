using Newtonsoft.Json;
using PrisImoveis.WebApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisImoveis.WebApp.Models.Dto
{
    public class ImovelDto
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("TipoDeImovel")]
        public ETipoDeImovel TipoDeImovel { get; set; }

        [JsonProperty("Cep")]
        public string Cep { get; set; }

        [JsonProperty("Logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("Numero")]
        public string Numero { get; set; }

        [JsonProperty("Descricao")]
        public string Descricao { get; set; }

        [JsonProperty("Valor")]
        public decimal Valor { get; set; }
    }
}
