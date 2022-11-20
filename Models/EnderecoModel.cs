using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Model
{
      public class EnderecoModel
    {
        [JsonPropertyName("cep")] 
        public string? Cep { get; set; }  // os ? sao para evitar os warm de nulo 

        [JsonPropertyName("state")] // ceralizar se o nome da propridade for diferente do nome do retorno da API => minha prop em pt , mas no JSON esta em ENG
        public string? Estado { get; set; }

        [JsonPropertyName("city")]
        public string? Cidade { get; set; }

        [JsonPropertyName("neighborhood")]
        public string? Regiao { get; set; }

        [JsonPropertyName("street")]
        public string? Rua { get; set; }

        [JsonPropertyName("service")]
        public string? Servico { get; set; }
    }

    
}