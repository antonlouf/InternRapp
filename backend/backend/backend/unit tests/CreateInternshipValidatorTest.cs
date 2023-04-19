using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Common;
using backend.Application.Units.Commands.CreateUnit;
using FluentValidation.TestHelper;
using Moq;

namespace unit_tests;
public class CreateInternshipValidatorTest
{
    [Fact]
    public void SchoolYear_Empty_Should_Throw_Validation_Error()
    {
        var mockedDbContext = new Mock<IApplicationDbContext>();

        var validator = new CreateInterShipCommandValidator(mockedDbContext.Object);
        var command = new CreateInternShipCommand()
        {
            Dto = new()
            {
                CurrentCountOfStudents = 10,
                Locations = new List<LocationDto>
                                                      {
                                                          new(){City="Antwerp", Housenumber=51,Streetname="Ellermanstraat",Zipcode="2260"}
                                                      },
                MaxCountOfStudents = 20,
                TrainingType = 0,
                UnitId = 1,
                Versions = new List<LanguageSpecificInternShipDto>()
                {
                    new(){Comment="test",Content="test",Description="test",KnowledgeToDevelop="test",LanguageId=1,Location="test",NeededKnowledge="test",TitleContent="test"}
                }
            }
        };
        var result = validator?.TestValidate(command);
        result?.ShouldHaveValidationErrorFor(x => x.Dto.SchoolYear);
    }
}
