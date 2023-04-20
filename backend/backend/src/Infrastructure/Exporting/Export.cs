using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace backend.Infrastructure.Exporting;
public class Export
{
    //deze classe wordt aangesproken wanneer een API route wordt gehit

    //veel parameters 
    public void docX()
    {
        using (DocX document = DocX.Create("Test.docx"))
        {
            // Add a new Paragraph to the document.
            Paragraph p = document.InsertParagraph();

            // Append some text.
            p.Append("Hello World").Font("Arial Black");

            // Save the document.
            document.Save();
        }

    }
}



