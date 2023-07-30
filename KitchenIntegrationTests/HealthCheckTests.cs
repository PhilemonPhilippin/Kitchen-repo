using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace KitchenIntegrationTests;

public class HealthCheckTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public HealthCheckTests(WebApplicationFactory<Program> factory)
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
