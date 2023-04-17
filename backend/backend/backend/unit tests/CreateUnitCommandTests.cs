using backend.Application.Common.Interfaces;
using backend.Application.Units.Commands.CreateUnit;
using FluentValidation.TestHelper;
using Moq;
using Xunit;

namespace unit_tests;

public class CreateUnitCommandTests
{
    [Fact]
    public void SuperVisorEmails_Empty_Should_Throw_Validation_Error()
    {
        var mockedDbContext = new Mock<IApplicationDbContext>();
        
        var validator = new CreateUnitValidator(mockedDbContext.Object);
        var command = new CreateUnitCommand();
        var result= validator?.TestValidate(command);
        result?.ShouldHaveValidationErrorFor(x => x.SuperVisorEmails);
    }
    [Fact]
    public void UnitName_Empty_Should_Throw_Validation_Error()
    {
        var mockedDbContext = new Mock<IApplicationDbContext>();

        var validator = new CreateUnitValidator(mockedDbContext.Object);
        var command = new CreateUnitCommand() { SuperVisorEmails = new() { "recep@inetum-realdolmen.world"} };
        var result = validator?.TestValidate(command);
        result?.ShouldHaveValidationErrorFor(x => x.Name);
    }
 
}