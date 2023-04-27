using System.Collections.Generic;
using System.Linq;
using backend.Application.Common.Paging;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Commands.UpdateInternShip;
using backend.Application.InternShips.Common;
using backend.Application.InternShips.Queries.GetAllInternShips;
using backend.Application.InternShips.Queries.GetExportInternShipData;
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
    //[HttpGet ]
    //public async Task<IActionResult> GetAll()
    //{
    //    return Ok(await _mediator.Send(new GetAllQuery()));
    //}

    [HttpGet]
    public async Task<IActionResult> GetFiltered([FromQuery] InternShipFilteredDto dto)
    {
        return Ok(await _mediator.Send(new GetFilteredQuery { Dto = dto }));
    }

    [HttpGet("export")] 
    public async Task<IActionResult> Export([FromQuery] InternshipExportRequestDto dto)
    {
        var filteredData = await _mediator.Send(new GetExportInterShipQuery { Dto = dto });
        Exporting Exporting = new Exporting();
        Exporting.GenerateWordDoc(filteredData);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update(InternShipUpdateDto dto)
    {
        await _mediator.Send(new UpdateInternShipCommand() { Dto = dto });
        return Ok();
    }

}
