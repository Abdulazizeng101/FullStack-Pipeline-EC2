using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Calculator API is running");
app.MapGet("/add", (int a, int b) => new { result = a + b });
app.MapGet("/subtract", (int a, int b) => new { result = a - b });
app.MapGet("/multiply", (int a, int b) => new { result = a * b });
app.MapGet("/divide", (int a, int b) => b == 0 ? "Cannot divide by zero" : (object)new { result = (double)a / b });

app.Run();
