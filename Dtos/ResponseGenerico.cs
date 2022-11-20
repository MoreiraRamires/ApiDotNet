using System.Dynamic;
using System.Net;

namespace IntegraBrasilApi.Dtos
{
    //objeto generico <T>
    public class ResponseGenerico<T> where T: class
    
    {
        public HttpStatusCode CodigoHttp { get; set; }

        public T? DadosRetorno { get; set; }


        public ExpandoObject? ErroRetorno { get; set; } // eu posso falar que esse tipo complexo é um objeto?
        
        
        
        
    }

}