using Refit;
using WebAPIConsultaCep.Integracao.Response;

namespace WebAPIConsultaCep.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}
