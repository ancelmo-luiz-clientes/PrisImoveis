using Microsoft.AspNetCore.Mvc;
using PrisImoveis.Donimio.IRepositories;
using PrisImoveis.Historias.Imoveis;
using PrisImoveis.WebApp.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisImoveis.WebApp.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly CriarImovel _criarImovel;
        private readonly ConsultarImoveis _consultarImoveis;
        public ImoveisController(IImovelRepository imovelRepository)
        {
            _criarImovel = new CriarImovel(imovelRepository);
            _consultarImoveis = new ConsultarImoveis(imovelRepository);
        }

        public async Task<IActionResult> Index()
        {
            var imoveis = await _consultarImoveis.ListarTodosImoveis();
            var listaImovelViewMovel = ImovelFactory.MapearListaImovelViewModel(imoveis);

            return View(listaImovelViewMovel.OrderBy(x => x.Valor));
        }


    }
}
