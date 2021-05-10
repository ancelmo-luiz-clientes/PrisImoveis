using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return Ok();
        }
    }
}
