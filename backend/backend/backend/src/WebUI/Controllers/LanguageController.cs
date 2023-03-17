﻿using backend.Application.Common.Paging;
using backend.Application.InternShips.Common;
using backend.Application.Languages.Commands.CreateLanguage;
using backend.Application.Languages.Commands.DeleteLanguage;
using backend.Application.Languages.Commands.UpdateLanguage;
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
    [HttpPost()]
    public async Task<IActionResult> PostLanguage(string languagenName)
    {
         await _mediator.Send(new CreateLanguageCommand() { Name=languagenName });
        return Ok();
    }
    [HttpPatch()]
    public async Task<IActionResult> UpdateLanguage(LanguageListDto dto)
    {
        await _mediator.Send(new UpdateLanguageCommand() { Dto=dto });
        return Ok();
    }
    [HttpDelete()]
    public async Task<IActionResult> DeleteLanguage(int id)
    {
        await _mediator.Send(new DeleteLanguageCommand() { Id=id });
        return Ok();
    }
}