using backend.Application.Common.Paging;
using backend.Application.Languages.Queries.GetAllLanguages;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;
[ApiController]
[Route("/api/[Controller]")]
public class LanguageController : ControllerBase
{
    private readonly IMediator _mediator;

    public LanguageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet()]
    public async Task<IActionResult> GetAllByfilterAndPage([FromQuery] FilterAndPaginationRequestDto dto)
    {



        var list = await _mediator.Send(new GetAllQuery() { Dto = dto });
        return Ok(list);
    }
}
