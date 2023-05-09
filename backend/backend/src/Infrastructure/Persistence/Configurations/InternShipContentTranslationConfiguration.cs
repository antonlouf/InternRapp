using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using backend.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infrastructure.Persistence.Configurations;
public class InternShipContentTranslationConfiguration : IEntityTypeConfiguration<InternShipContentTranslation>
{
    public void Configure(EntityTypeBuilder<InternShipContentTranslation> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.Property(x => x.TitleContent).IsRequired().HasMaxLength(40);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(350);
        builder.Property(x => x.KnowledgeToDevelop).IsRequired().HasMaxLength(250);
        builder.Property(x => x.NeededKnowledge).IsRequired().HasMaxLength(250);
       
        builder.Property(x => x.Comment).IsRequired().HasMaxLength(250);

        var trnslNl = new InternShipContentTranslation
        {
            Id = 1,
            TitleContent = "InternRapp",
            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
            Comment = $"<p>required diploma for this internship is: {TrainingType.Bachelor}<p>",
            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
            InternShipId = 1,
            Location = "new location",
            LanguageId=1
            

        };



        var trnslFr = new InternShipContentTranslation
        {
            Id = 2,
            TitleContent = "InternRapp",
            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
            Comment = $"<p>required diploma for this internship is: {TrainingType.Bachelor}<p>",
            LanguageId = 3,
            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
            InternShipId = 1,
            Location = "new location"


        };



        var trnslEng = new InternShipContentTranslation
        {
            Id = 3,
            TitleContent = "InternRapp",
            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
            Comment = $"<p>required diploma for this internship is: {TrainingType.Bachelor}<p>",
            LanguageId = 2,
            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
            InternShipId=1,
            Location="new location"


        };
        builder.HasData(new List<InternShipContentTranslation>()
        {
           trnslEng, trnslFr, trnslNl
        });

    }
}
