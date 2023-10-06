using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PriceComparison.WebApi.Controllers;

[ApiController]
[Route("categories")]
public class CategoryController : ControllerBase
{
    private readonly ISender _sender;

    public CategoryController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok();
    }
}