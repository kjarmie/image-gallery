var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();

var app = builder.Build();

app.MapControllers();

// app.MapGet("/", () => "Hello World!");

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();
app.Run();