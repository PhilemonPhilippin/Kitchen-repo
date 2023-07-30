using Serilog;

const string AllowKitchenNG = "_allowKitchenNG";

// Serilog Configuration.
Log.Logger = new LoggerConfiguration()
.MinimumLevel.Debug()
.WriteTo.Console()
.WriteTo.File("logs/kitchen.txt", rollingInterval: RollingInterval.Day, restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information)
.CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.RegisterServices(builder.Configuration, AllowKitchenNG);

builder.Host.UseSerilog();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(AllowKitchenNG);

app.UseAuthorization();

app.MapControllers();

app.MapHealthChecks("/health");

app.Run();

// Makes my Program public so i can expose it to my Integration tests project.
public partial class Program { }