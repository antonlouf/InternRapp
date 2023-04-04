using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using backend.Application.Common.Paging;
using backend.Application.InternShips.Common;
using backend.Application.Languages.Commands.CreateLanguage;
using backend.Application.Languages.Commands.DeleteLanguage;
using backend.Application.Languages.Commands.UpdateLanguage;
using backend.Application.Languages.Queries.GetAllLanguages;
using backend.Application.Languages.Queries.GetLanguageById;
using Duende.IdentityServer.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

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

    [HttpGet]
    public async Task<IActionResult> GetAllByfilterAndPage([FromQuery] FilterAndPaginationRequestDto dto)
    {
        var list = await _mediator.Send(new GetAllQuery() { Dto = dto });
        return Ok(list);
    }
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute]int id)
    {
        var language = await _mediator.Send(new GetByIdQuery() { Dto = new() { Id = id } });
        return Ok(language);
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
    [HttpGet("{language}")]
    public async Task<IActionResult> GetLocalizationFileAsDict([FromRoute] string language)
    {
       
        ResourceManager rm = new ResourceManager($"WebUI.Resources.{language.ToString()}",Assembly.GetExecutingAssembly());
        var myResourceSet = rm.GetResourceSet(CultureInfo.CurrentCulture, true, true);
        var resourceSet=myResourceSet.GetEnumerator();
        Dictionary<string, string> translations = new();
        while(resourceSet.MoveNext())
        {

            translations.Add(resourceSet.Key.ToString(), resourceSet.Value.ToString());
            
        }
        return Ok(translations);
    }

}
