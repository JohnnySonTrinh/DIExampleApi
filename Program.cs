var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Temporary root endpoint just to confirm it runs
app.MapGet("/", () => "Dependency Injection Example API is running...");

app.Run();
