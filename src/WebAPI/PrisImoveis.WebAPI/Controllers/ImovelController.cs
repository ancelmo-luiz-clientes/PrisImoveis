using Microsoft.AspNetCore.Mvc;
using PrisImoveis.Donimio.Enums;
using PrisImoveis.Donimio.IRepositories;
using PrisImoveis.Historias.Imoveis;
using PrisImoveis.WebAPI.Factories;
using PrisImoveis.WebAPI.Models;
using System.Collections.Generic;
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

        [HttpPost("criar")]
        public async Task<IActionResult> Criar([FromBody] ImovelViewModel imovelViewModel)
        {
            var imovel = ImovelFactory.MapearImovel(imovelViewModel);

            await _criarImovel.Executar(imovel);

            return Ok(new { msg = "Imóvel criado com sucesso" });
        }

      
        [HttpGet("listar-todos")]
        public async Task<IEnumerable<ImovelViewModel>> ListarTodosImoveis()
        {

            var imoveis = await _consultarImoveis.ListarTodosImoveis();

            var listaImovelViewMovel = ImovelFactory.MapearListaImovelViewModel(imoveis);

            return listaImovelViewMovel;
        }

        [HttpGet("listar-por-tipo/{tipoImovel}")]
        public async Task<IEnumerable<ImovelViewModel>> ListarPorTipoDeImovel(ETipoDeImovel tipoDeImovel)
        {
            var imoveis = await _consultarImoveis.ListarPorTipoDeImovel(tipoDeImovel);

            var listaImovelViewMovel = ImovelFactory.MapearListaImovelViewModel(imoveis);

            return listaImovelViewMovel;
        }

    }
}
