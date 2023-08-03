using System.Net;

namespace KitchenIntegrationTests;

public class HealthCheckTests : IClassFixture<WebApplicationFactoryKitchenTest<Program>>
{
    private readonly WebApplicationFactoryKitchenTest<Program> _factory;

    public HealthCheckTests(WebApplicationFactoryKitchenTest<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task HealthCheck_ReturnsOk()
    {
        // Arrange
        var httpClient = _factory.CreateClient();

        // Act
        var response = await httpClient.GetAsync("/health");

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
