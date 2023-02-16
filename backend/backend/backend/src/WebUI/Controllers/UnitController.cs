using backend.Application.Units.Commands.CreateUnit;
using backend.Application.Units.Commands.DeleteUnit;
using backend.Application.Units.Commands.UpdateUnit;
using backend.Application.Units.Queries.GetAllUnits;
using backend.Application.Units.Queries.GetUnitById;
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
    //[HttpGet]
    //public async Task<IActionResult> Create()
    //{
    //    await _mediator.Send(new CreateUnitCommand() { Name = "HR", SuperVisorId = 1 });
    //    return Ok();
    //}
    [HttpGet("{id:int}")]
    
    public async Task<IActionResult> GetById(int id)
    {
       return Ok(await _mediator.Send(new GetByIdQuery() { Id=id}));
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllQuery());
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update(UnitListDto dto)
    {
         await _mediator.Send(new UpdateUnitCommand() { Unit=dto});
        return Ok("successfully updated");
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new DeleteUnitCommand() { Id=id});
        return Ok("successfully deleted");
    }
}
