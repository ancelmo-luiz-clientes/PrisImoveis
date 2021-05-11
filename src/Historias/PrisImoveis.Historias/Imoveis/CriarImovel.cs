using PrisImoveis.Donimio.Entidades;
using PrisImoveis.Donimio.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrisImoveis.Historias.Imoveis
{
    public class CriarImovel
    {
        public Dictionary<string, string> Erros { get; private set; } = new Dictionary<string, string>();
        private readonly IImovelRepository _imovelRepository;

        public CriarImovel(IImovelRepository imovelRepository)
        {
            _imovelRepository = imovelRepository;
        }

        public async Task Executar(Imovel imovel)
        {
            try
            {
                await _imovelRepository.Criar(imovel);
            }
            catch (System.Exception)
            {
                this.Erros.Add("Erro", "Ocorreu um erro ao criar um imóvel.");
            }

        }

    }
}
