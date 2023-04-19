using backend.Application.Common.Interfaces;
using backend.Application.Units.Commands.UpdateUnit;
using backend.Application.Units.Queries.GetAllUnits;
using backend.Domain.Entities;
using FluentValidation.TestHelper;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace unit_tests;
public class UpdateUnitCommandTests
{
    [Fact]
    public void SuperVisorEmails_Empty_Should_Throw_Validation_Error()
    {
        var mockDbContext = new Mock<IApplicationDbContext>();
        var unit = new UnitListDto { Id = 1, Name = "Java" };
        var mockDbSet = new Mock<DbSet<Department>>();
        var department = new Department { Id = 1, Name = "Java", ManagerEmails = new List<string> { "jane.doe@example.com" } };

        var command = new UpdateUnitCommand { Unit = unit };
        mockDbContext.Setup(x => x.Departments).Returns(mockDbSet.Object);
      //  mockDbSet.Setup(x => x.FirstOrDefaultAsync(x => x.Id ==command.Unit.Id)).ReturnsAsync(department);
        var validator = new UpdateUnitCommandValidator(mockDbContext.Object);
        var result = validator?.TestValidate(command);
        result?.ShouldHaveValidationErrorFor(x => x.Unit.ManagerEmails);
    }
    [Fact]
    public void Id_Empty_Should_Throw_Validation_Error()
    {
        var mockDbContext = new Mock<IApplicationDbContext>();
        var unit = new UnitListDto { Name = "Java", ManagerEmails = new List<string> { "jane.doe@example.com" } };
        var mockDbSet = new Mock<DbSet<Department>>();

        var command = new UpdateUnitCommand { Unit = unit };
        mockDbContext.Setup(x => x.Departments).Returns(mockDbSet.Object);
        //  mockDbSet.Setup(x => x.FirstOrDefaultAsync(x => x.Id ==command.Unit.Id)).ReturnsAsync(department);
        var validator = new UpdateUnitCommandValidator(mockDbContext.Object);
        var result = validator?.TestValidate(command);
        result?.ShouldHaveValidationErrorFor(x => x.Unit.Id);
    }
    [Fact]
    public void DepartmentName_Empty_Should_Throw_Validation_Error()
    {
        var mockDbContext = new Mock<IApplicationDbContext>();
        var unit = new UnitListDto { Id=1, ManagerEmails = new List<string> { "jane.doe@example.com" } };
        var mockDbSet = new Mock<DbSet<Department>>();

        var command = new UpdateUnitCommand { Unit = unit };
        mockDbContext.Setup(x => x.Departments).Returns(mockDbSet.Object);
        //  mockDbSet.Setup(x => x.FirstOrDefaultAsync(x => x.Id ==command.Unit.Id)).ReturnsAsync(department);
        var validator = new UpdateUnitCommandValidator(mockDbContext.Object);
        var result = validator?.TestValidate(command);
        result?.ShouldHaveValidationErrorFor(x => x.Unit.Name);
    }
}
