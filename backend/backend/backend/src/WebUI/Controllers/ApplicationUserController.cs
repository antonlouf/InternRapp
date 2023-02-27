using backend.Application.ApplicationUsers.Commands.CreateApplicationUserCommand;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Commands.UpdateInternShip;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;
[ApiController]
[Route("/api/[Controller]")]
public class ApplicationUserController : ControllerBase
{
    private readonly IMediator _mediator;
    public ApplicationUserController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateApplicationUserCommand dto)
    {
        await _mediator.Send(dto);
        return Ok();
    }
    //[HttpGet]
    //public async Task<IActionResult> GetAll()
    //{
    //    var result = await _mediator.Send(new GetAllQuery());
    //    return Ok(result);
    //}
    //[HttpPut]
    //public async Task<IActionResult> Update(InternShipUpdateDto dto)
    //{
    //    await _mediator.Send(new UpdateInternShipCommand() { Dto = dto });
    //    return Ok();
    //}
}
