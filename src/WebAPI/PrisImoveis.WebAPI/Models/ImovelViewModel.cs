using Microsoft.AspNetCore.Mvc;
using PrisImoveis.Donimio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrisImoveis.WebAPI.Models
{
    public class ImovelViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public ETipoDeImovel TipoDeImovel { get; set; }
        [Required(ErrorMessage = "{0} é requerido")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public decimal Valor { get; set; }
    }
}
