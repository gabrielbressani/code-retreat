using CodeRetreat.Application.Model;
using Refit;
using System.Threading.Tasks;

namespace CodeRetreat.Application.API
{
    public interface IUniversoAPI
    {
        [Get("/universoconfig")]
        Task<ConiguracaoDoUniverso> ObterConfiguracao();
    }
}
