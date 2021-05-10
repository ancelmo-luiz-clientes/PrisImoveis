using Microsoft.AspNetCore.Mvc;
using PrisImoveis.Donimio.Enums;
using PrisImoveis.Donimio.IRepositories;
using PrisImoveis.Historias.Imoveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisImoveis.WebAPI.Controllers
{
    [Route("api/imoveis")]
    public class ImovelController : ControllerBase
    {
        private readonly CriarImovel _criarImovel;
        private readonly ConsultarImoveis _consultarImoveis;

        public ImovelController(IImovelRepository imovelRepository)
        {
            _criarImovel = new CriarImovel(imovelRepository);
            _consultarImoveis = new ConsultarImoveis(imovelRepository);
        }

        [HttpPost]
        public async Task<IActionResult> Criar()
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Alterar()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> ListarTodosImoveis()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> ListarPorTipoDeImovel(ETipoDeImovel tipoDeImovel)
        {
            return Ok();
        }

    }
}
