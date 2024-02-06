using RocketseatAuction.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace RocketseatAuction.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCurrentAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();

        return Ok(result);
    }
}