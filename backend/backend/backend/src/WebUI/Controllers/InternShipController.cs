using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Queries.GetAllInternShips;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;
[ApiController]
[Route("/api/[Controller]")]
public class InternShipController : ControllerBase
{
    private readonly IMediator _mediator;
    public InternShipController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateInternShipCommand dto)
    {
        await _mediator.Send(dto);  
        return Ok();
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result=await _mediator.Send(new GetAllQuery());
        return Ok(result);
    }

}
