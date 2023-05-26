using System.Collections;
using backend.Application.Common.Interfaces;
using backend.Application.Common.Paging;
using backend.Application.InternShips.Commands.CopyInternshipToNextYear;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Commands.DeleteInternship;
using backend.Application.InternShips.Commands.UpdateInternShip;
using backend.Application.InternShips.Queries.GetExportInternShipData;
using backend.Application.InternShips.Queries.getFilteredInternShip;
using backend.Application.InternShips.Queries.GetInternShipById;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace WebUI.Controllers;
[ApiController]
[Route("/api/[Controller]")]
public class InternShipController : ControllerBase
{
    private readonly IMediator _mediator;
    public InternShipController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] InternShipCreateDto dto)
    {

        await _mediator.Send(new CreateInternShipCommand()
        {
            CurrentCountOfStudents = dto.CurrentCountOfStudents,
            Locations = dto.Locations,
            MaxCountOfStudents = dto.MaxCountOfStudents,
            TrainingType = dto.TrainingType,
            SchoolYear = dto.SchoolYear,
            UnitId = dto.UnitId,
            Versions = dto.Versions
        });
        return Ok();
    }
    [HttpPost, Route("copyToNextYear")]
    public async Task<IActionResult> Create([FromBody] List<int> ids)
    {
        await _mediator.Send(new CopyInternshipToNextYearCommand() { IdsOfExistingInternships = ids });

        return Ok();
    }
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdQuery() { Id = id });
        return Ok(result);
    }
    [HttpGet]
    public async Task<IActionResult> GetFiltered([FromQuery] InternShipFilteredDto dto)
    {

        return Ok(await _mediator.Send(new GetFilteredQuery() { PageIndex = dto.PageIndex, PageSize = dto.PageSize, LanguageIds = dto.LanguageIds, SchoolYear = dto.SchoolYear, UnitIds = dto.UnitIds }));
    }

    [HttpGet("export")]
    public async Task<IActionResult> Export([FromQuery] InternshipExportRequestDto request, [FromServices] IApplicationDbContext dbContext)
    {
        List<UnitExportDto> exportData = await _mediator.Send(new GetExportInterShipQuery()
        {
            LanguageId = request.LanguageId,
            SchoolYear = request.SchoolYear,
            UnitIds = request.UnitIds,
        });
        Exporting exporting = new Exporting(dbContext);

        using(var a = exporting.GenerateWordDoc(exportData, request))
        {
           // a.Position = 0;


            //await a.CopyToAsync(HttpContext.Response.Body);
            HttpContext.Response.ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
 

           
            //return File(Response.Body, "application/msword; charset=utf-8", "bla.docx"); //werkt ni 
        }


        //binary optie 
        MemoryStream mstream = exporting.GenerateWordDoc(exportData, request);
        byte[] byteArray = mstream.ToArray();
        mstream.Flush();
        mstream.Close();
        Response.Clear();
        //or new BinaryWriter(mstream);


        HttpContext.Response.Headers.Add("Content", "attachment; filename=foo.docx");
        // Add a HTTP header to the output stream that contains the 
        // content length(File Size). This lets the browser know how much data is being transfered
        HttpContext.Response.Headers.Add("Content", byteArray.Length.ToString());
        // Set the HTTP MIME type of the output stream
        Response.ContentType = "application/octet-stream";
        // Write the data out to the client.
        
        Response.BodyWriter(byteArray);
        

    }

    [HttpPut]
    public async Task<IActionResult> Update(InternShipUpdateDto dto)
    {
        await _mediator.Send(new UpdateInternShipCommand()
        {
            Versions = dto.Versions,
            CurrentCountOfStudents = dto.CurrentCountOfStudents,
            InternShipId = dto.InternShipId,
            Locations = dto.Locations,
            MaxCountOfStudents = dto.MaxCountOfStudents,
            SchoolYear = dto.SchoolYear,
            TrainingType = dto.TrainingType,
            UnitId = dto.UnitId,
        });
        return Ok();
    }
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromBody] List<int> ids)
    {
        await _mediator.Send(new DeleteInternshipCommand() { Ids = ids });
        return Ok();
    }

}
