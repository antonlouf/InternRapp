using backend.Application.Units.Commands.CreateUnit;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;
[ApiController]
[Route("/api/[Controller]")]
public class UnitController : ControllerBase
{
    private IMediator _mediator;
    public UnitController(IMediator mediator)
    {
        _mediator= mediator;    
    }
    //later to be adjusted dependent on what the situation should be see createunitcommand for more details!!
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        await _mediator.Send(new CreateUnitCommand() { Name = "HR", SuperVisorId = 1 });
        return Ok();
    }
}
