using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PriceComparison.WebApi.Controllers;

[ApiController]
[Route("products")]
public class ProductController: ControllerBase
{
    private readonly ISender _sender;

    public ProductController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok();
    }
}