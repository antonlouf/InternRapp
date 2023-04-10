using Microsoft.AspNetCore.Mvc;
using MediatR;
using backend.Application.Common.Paging;
using backend.Application.Locations.Queries.GetAllLocations;
using backend.Application.InternShips.Common;
using backend.Application.Locations.Commands.CreateLocation;
using backend.Application.Languages.Commands.CreateLanguage;
using backend.Application.Languages.Commands.UpdateLanguage;
using backend.Application.Locations.Commands.UpdateLocation;
using backend.Application.Languages.Commands.DeleteLanguage;
using backend.Application.Locations.Commands.DeleteLocation;

namespace WebUI.Controllers;
[ApiController]
[Route("/api/[Controller]")]

public class LocationController: ControllerBase
{
    private readonly IMediator _mediator;

    public LocationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllByfilterAndPage([FromQuery] FilterAndPaginationRequestDto dto)
    {
        var list = await _mediator.Send(new GetAllQuery() { Dto = dto });
        return Ok(list);
    }
    [HttpPost()]
    public async Task<IActionResult> PostLocation(CreateLocationDto location)
    {
           //ToDo - Null check / empty -> bad request
           //ToDo - Web contract / application  contract should be different.
            await _mediator.Send(new CreateLocationCommand() { LocationDto = location });
        return Ok();
    }
    [HttpPatch()]
    public async Task<IActionResult> UpdateLocation(LocationDto dto)
    {
        //ToDo - Null check / empty -> bad request
        //ToDo - Web contract / application  contract should be different.
        await _mediator.Send(new UpdateLocationCommand() { Dto = dto });
        return Ok();
    }
    [HttpDelete()]
    public async Task<IActionResult> UpdateLocation(int id)
    {
        await _mediator.Send(new DeleteLocationCommand() { Id = id });
        return Ok();
    }

}
