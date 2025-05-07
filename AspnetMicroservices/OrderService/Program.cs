var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("products", c =>
{
    c.BaseAddress = new Uri("http://productservice:80");
});

builder.Services.AddControllers();
builder.WebHost.UseUrls("http://0.0.0.0:81");

var app = builder.Build();

app.MapControllers();

app.Run();


