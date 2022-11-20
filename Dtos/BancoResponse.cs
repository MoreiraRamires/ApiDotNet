using System.Dynamic;
using System.Net;

namespace IntegraBrasilApi.Dtos
{
    //objeto generico <T>
    // Eu faço os DTOs para ter um retorno personalisado. Não quero nomes em Inglês.
    public class BancoResponse
    {
        public string? Ispb { get; set; }
        public string? NomeAbreviado { get; set; }
        public int? Codigo { get; set; }
        public string? NomeCompleto { get; set; }
    }

}