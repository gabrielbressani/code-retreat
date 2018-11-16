using CodeRetreat.Application.API;
using CodeRetreat.Application.Service;
using Refit;
using Xunit;

namespace CodeRetreat.Test
{
    public class GeradorDeUniversoTest
    {

        [Fact]
        public void OGeradorDeUniversoRetornaUmaMatrizNXM()
        {
            IUniversoAPI universoApi = RestService.For<IUniversoAPI>("http://demo0654407.mockable.io");
            var geradorDeUniverso = new GeradorDeUniverso(universoApi);

            int[,] atual = geradorDeUniverso.ObterTabuleiro();

            int[,] esperado = new int[8, 8];
            Assert.Equal(esperado, atual);
        }

    }
}
