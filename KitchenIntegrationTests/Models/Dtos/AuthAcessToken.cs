using System.Text.Json.Serialization;

namespace KitchenIntegrationTests.Models.Dtos
{
    public class AuthAccessToken
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; } = string.Empty;
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; } = string.Empty;
    }
}
