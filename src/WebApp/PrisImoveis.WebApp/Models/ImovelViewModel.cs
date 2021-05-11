using Microsoft.AspNetCore.Mvc;
using PrisImoveis.Donimio.Enums;
using System.ComponentModel.DataAnnotations;

namespace PrisImoveis.WebApp.Models
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
