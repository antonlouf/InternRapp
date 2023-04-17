using backend.Application.Common.Paging;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Commands.DeleteInternship;
using backend.Application.InternShips.Commands.UpdateInternShip;
using backend.Application.InternShips.Queries.GetAllInternShips;
using backend.Application.InternShips.Queries.GetExportInternShipData;
using backend.Application.InternShips.Queries.getFilteredInternShip;
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
        await _mediator.Send(new CreateInternShipCommand() { Dto = dto });
        return Ok();
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdQuery() { Id = id });
        return Ok(result);
    }
    [HttpGet]
    public async Task<IActionResult> GetFiltered([FromQuery] InternShipFilteredDto dto)
    {
       
        return Ok(await _mediator.Send(new GetFilteredQuery() { Dto = dto }));
    }

    [HttpGet("export")]
    public async Task<IActionResult> Export([FromQuery] InternshipExportDto dto)
    {
        
        return Ok(await _mediator.Send(new GetExportInterShipQuery() { Dto = dto }));
    }

    [HttpPut]
    public async Task<IActionResult> Update(InternShipUpdateDto dto)
    {
        await _mediator.Send(new UpdateInternShipCommand() { Dto = dto });
        return Ok();
    }
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        await _mediator.Send(new DeleteInternshipCommand() { Id=id });
        return Ok();
    }

}
