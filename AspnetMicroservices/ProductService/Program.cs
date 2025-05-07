var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("orders", c =>
{
    c.BaseAddress = new Uri("http://orderservice:5001");
});

builder.Services.AddControllers();
builder.WebHost.UseUrls("http://0.0.0.0:80");

var app = builder.Build();

app.MapControllers();

app.Run();


