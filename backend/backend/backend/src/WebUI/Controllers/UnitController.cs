using backend.Application.Common.Interfaces;
using backend.Application.Units.Commands.CreateUnit;
using backend.Application.Units.Commands.DeleteUnit;
using backend.Application.Units.Commands.UpdateUnit;
using backend.Application.Units.Queries.GetAllUnits;
using backend.Application.Units.Queries.GetUnitById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebUI.Controllers;
[ApiController]
[Route("/api/[Controller]")]
public class UnitController : ControllerBase
{
    private IMediator _mediator;
    private readonly IApplicationDbContext _dbContext;
    public UnitController(IMediator mediator, IApplicationDbContext dbContext)
    {
        _mediator = mediator;
        _dbContext = dbContext;
    }
    //later to be adjusted dependent on what the situation should be see createunitcommand for more details!!
    [HttpPost]
    public async Task<IActionResult> Create( CreateUnitCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
    [HttpGet("{id:int}")]
    
    public async Task<IActionResult> GetById(int id)
    {
       return Ok(await _mediator.Send(new GetByIdQuery() { Id=id}));
    }

    [HttpGet()]
    public async Task<IActionResult> GetAllByfilterAndPage([FromQuery] UnitFilterAndPaginationRequestDto dto)
    {
        var splittedFilter=dto.Filter.Split(':');
        if (splittedFilter.Length > 1)
        {
            dto.Filter = splittedFilter[1];
        }
       
        
        var list = await _mediator.Send(new GetAllQuery(){Dto=dto });
        return Ok(list);
    }
    //[HttpGet]
    //public async Task<IActionResult> GetAll()
    //{
    //    var result = await _mediator.Send(new GetAllQuery());
    //    return Ok(result);
    //}

    [HttpPatch]
    public async Task<IActionResult> Update(UnitListDto dto)
    {
         await _mediator.Send(new UpdateUnitCommand() { Unit=dto});
        return Ok("successfully updated");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new DeleteUnitCommand() { Id=id});
 
        return Ok($"{id}");
    }
}
