using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Model
{
      public class BancoModel
    {
        [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }

        [JsonPropertyName("name")] //para que o code entenda que minha prop tem um nome diferente do retorno em JSON na minha API
        public string? Nome { get; set; }

        [JsonPropertyName("code")]
        public int? Codigo { get; set; }

        [JsonPropertyName("fullName")] 
        public string? NomeCompleto { get; set; }
    }
    
}