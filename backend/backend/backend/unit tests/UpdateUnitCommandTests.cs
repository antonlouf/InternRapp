using System.Linq.Expressions;
using backend.Application.Common.Interfaces;
using backend.Application.Units.Commands.UpdateUnit;
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
        var mockedDbContext = new Mock<IApplicationDbContext>();
        var command = new UpdateUnitCommand() { Unit = new() { Name = "Java", Id = 1 } };

        mockedDbContext.Setup(x => x.Departments.FirstOrDefaultAsync(x => It.IsAny<bool>(),It.IsAny<CancellationToken>())).ReturnsAsync(new Department() { Name = command.Unit.Name, ManagerEmails = command.Unit.ManagerEmails });
        var validator = new UpdateUnitCommandValidator(mockedDbContext.Object);
        var result = validator?.TestValidate(command);
        result?.ShouldHaveValidationErrorFor(x => x.Unit.ManagerEmails);
    }
}
