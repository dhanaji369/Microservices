using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly HttpClient _client;

    public OrdersController(IHttpClientFactory httpClientFactory)
    {
        _client = httpClientFactory.CreateClient("products");
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await _client.GetStringAsync("/api/products");
        return Ok(new { Message = "Order placed!", Products = products });
    }
}
