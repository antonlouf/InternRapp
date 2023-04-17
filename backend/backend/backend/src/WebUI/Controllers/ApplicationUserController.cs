using backend.Application.ApplicationUsers.Commands.CreateApplicationUser;
using backend.Application.ApplicationUsers.Queries.GetApplicationUserByEmailContaining;
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
        if(dto is null)
        {
            return BadRequest();
        }

        //ToDo - Null check / empty -> bad request
        //ToDo - Web contract / application  contract should be different.

        await _mediator.Send(dto);
        return Ok();
    }
    [HttpGet]
    public async Task<IActionResult> GetAllEmailsContaining(string filterValue)
    {
        //ToDo - Null check / empty -> bad request
      
        var result = await _mediator.Send(new GetByEmailContainingQuery() { EmailAdress=filterValue});
        return Ok(result);
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
