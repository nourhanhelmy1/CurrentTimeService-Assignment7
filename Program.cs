var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/currentTime", () =>
{
    var currentTime = DateTime.Now.ToString();
    return Results.Ok(new { DateTime = currentTime });
});

app.Run();
