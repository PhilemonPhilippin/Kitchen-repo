namespace KitchenIntegrationTests.Tools;

public static class JsonSerializerHelper
{
    public static JsonSerializerOptions DefaultSerialisationOptions() => 
        new JsonSerializerOptions { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull };
    
}
