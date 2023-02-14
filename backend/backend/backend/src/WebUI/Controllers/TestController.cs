using backend.Application.ApplicationUsers.Commands.CreateApplicationUserCommand;
using backend.Application.ApplicationUsers.Queries.GetById;
using backend.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class TestController : ControllerBase
{
    private readonly IMediator _mediator;
    public TestController(IMediator mediator)
    {
        _mediator=mediator;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
      await _mediator.Send(new CreateApplicationUserCommand() { Email= "recepp4253@gmail.com",Role=Role.Admin });
        return Ok("Hello world");
    }

    [HttpGet,Route("/Module")]
    public async Task<IActionResult> Module()
    {
        var result=await _mediator.Send(new GetByIdQuery() { Id=1});
        return Ok(result);
    }
}
