using WebAPIConsultaCep.Integracao.Response;

namespace WebAPIConsultaCep.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);
    }
}
