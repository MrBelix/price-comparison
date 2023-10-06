using MediatR;
using Microsoft.AspNetCore.Mvc;
using PriceComparison.Application.Brands.Search;

namespace PriceComparison.WebApi.Controllers;

[ApiController]
[Route("brands")]
public class BrandController : ControllerBase
{
    private readonly ISender _sender;

    public BrandController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpGet]
    public async Task<IActionResult> Index([FromQuery]SearchBrandsQuery request)
    {
        return Ok(await _sender.Send(request));
    }
}