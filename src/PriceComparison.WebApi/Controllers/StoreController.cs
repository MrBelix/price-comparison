using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PriceComparison.WebApi.Controllers;

[ApiController]
[Route("store")]
public class StoreController : ControllerBase
{
    private readonly ISender _sender;

    public StoreController(ISender sender)
    {
        _sender = sender;
    }

    public async Task<IActionResult> Index()
    {
        return Ok();
    }
}