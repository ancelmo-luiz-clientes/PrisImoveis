using Microsoft.AspNetCore.Mvc;
using PrisImoveis.WebApp.ApiClients;
using PrisImoveis.WebApp.Factories;
using System.Threading.Tasks;

namespace PrisImoveis.WebApp.Controllers
{
    public class ImovelController : Controller
    {
        private readonly IPrisImoveisApi _prisImoveisApi;

        public ImovelController(IPrisImoveisApi prisImoveisApi)
        {
            _prisImoveisApi = prisImoveisApi;
        }

        public async Task<IActionResult> Index()
        {
            var imoveis = await _prisImoveisApi.ListarTodosImoveis();
            var lista = ImovelFactory.MapearListaImovelViewModel(imoveis);

            return View(lista);
        }

        public IActionResult Criar()
        {
            return View();
        }

    }
}
