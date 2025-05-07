using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<string> products = ["Apple", "Banana", "Laptop"];

    [HttpGet]
    public IActionResult Get() => Ok(products);

    [HttpPost]
    public IActionResult Add(string name)
    {
        products.Add(name);
        return Ok(products);
    }
}
