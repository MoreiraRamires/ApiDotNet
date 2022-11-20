

using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Model;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBrasilApiRest
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

    }


}