using backend.Application.Common.Paging;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Commands.UpdateInternShip;
using backend.Application.InternShips.Queries.GetAllInternShips;
using backend.Application.InternShips.Queries.getFilteredInternShip;
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
    public async Task<IActionResult> Create(InternShipCreateDto dto)
    {
        await _mediator.Send(new CreateInternShipCommand() { Dto = dto });
        return Ok();
    }
    /*[HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _mediator.Send(new GetAllQuery()));
    }*/
    [HttpGet]
    public async Task<IActionResult> GetFiltered([FromQuery] InternShipFilteredDto dto)
    {
        return Ok(await _mediator.Send(new GetFilteredQuery { Dto = dto}));
    }
    [HttpPut]
    public async Task<IActionResult> Update(InternShipUpdateDto dto)
    {
        await _mediator.Send(new UpdateInternShipCommand() { Dto=dto});
        return Ok();
    }

}
