using CodeRetreat.Application.API;
using CodeRetreat.Application.Model;

namespace CodeRetreat.Application.Service
{
    public class GeradorDeUniverso
    {
        private IUniversoAPI _universoAPI { get; }

        public GeradorDeUniverso(IUniversoAPI universoAPI)
        {
            _universoAPI = universoAPI;
        }

        public int[,] ObterTabuleiro()
        {
            ConiguracaoDoUniverso coniguracao = _universoAPI.ObterConfiguracao().Result;

            return new int[coniguracao.N, coniguracao.M];
        }
    }
}
