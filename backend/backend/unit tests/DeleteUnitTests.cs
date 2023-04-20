using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Units.Commands.CreateUnit;
using backend.Application.Units.Commands.DeleteUnit;
using FluentValidation.TestHelper;
using Moq;

namespace unit_tests;
public class DeleteUnitTests
{
    [Fact]
    public void SuperVisorEmails_Empty_Should_Throw_Validation_Error()
    {
        var mockedDbContext = new Mock<IApplicationDbContext>();

        var validator = new DeleteUnitCommandValidator(mockedDbContext.Object);
        var command = new DeleteUnitCommand() {  };
        var result = validator?.TestValidate(command);
        result.ShouldHaveValidationErrorFor(x => x.Id);
        
    }
}
