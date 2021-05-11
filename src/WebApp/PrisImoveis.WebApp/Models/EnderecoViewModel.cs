using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisImoveis.WebApp.Models
{
    public class EnderecoViewModel
    { 
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localicade { get; set; }
        public string Uf { get; set; }
    }
}
