using backend.Application.Common.Paging;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Commands.UpdateInternShip;
using backend.Application.InternShips.Queries.GetAllInternShips;
using backend.Application.InternShips.Queries.GetInternShipById;
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
    public async Task<IActionResult> Create([FromBody] InternShipCreateDto dto)
    {
        await _mediator.Send(new CreateInternShipCommand() { Dto=dto});  
        return Ok();
    }
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] FilterAndPaginationRequestDto dto)
    {
        var result=await _mediator.Send(new GetAllQuery() { Dto=dto});
        return Ok(result);
    }
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdQuery() { Id=id});
        return Ok(result);
    }
    [HttpPut]
    public async Task<IActionResult> Update(InternShipUpdateDto dto)
    {
        await _mediator.Send(new UpdateInternShipCommand() { Dto=dto});
        return Ok();
    }

}
