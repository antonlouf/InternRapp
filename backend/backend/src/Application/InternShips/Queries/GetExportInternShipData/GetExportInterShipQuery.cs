using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Resources;
using System.Text.RegularExpressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using backend.Application.InternShips.Common;
using backend.Application.InternShips.Queries.GetAllInternShips;
using backend.Application.InternShips.Queries.GetInternShipById;
using backend.Application.Units.Common;
using backend.Domain.Entities;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Queries.GetExportInternShipData;
public class GetExportInterShipQuery : IRequest<List<UnitExportDto>>
{
    public InternshipExportRequestDto Dto { get; set; }
}

public class GetExportInterShipQueryHandler : IRequestHandler<GetExportInterShipQuery, List<UnitExportDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private IMapper _iMapper;

    public GetExportInterShipQueryHandler(IApplicationDbContext dbContext, IMapper iMapper)
    {
        _dbContext = dbContext;
        _iMapper = iMapper;
    }

    public async Task<List<UnitExportDto>> Handle(GetExportInterShipQuery request, CancellationToken cancellationToken)
    {

        //Filter on Units and only the internships who have a translation language of request language 
        var units = await _dbContext.Departments
            .Where(unit => (request.Dto.UnitIds == null || request.Dto.UnitIds.Count == 0 || request.Dto.UnitIds.Contains(unit.Id))
            && unit.Internships.Any(intrShps => intrShps.Translations.Any(trnsl => request.Dto.LanguageId == trnsl.LanguageId))) //gecheckt -> werkt 

            .Select(x => new UnitExportDto()
            {
                Name = x.Name,
                PrefaceDto = x.PrefaceTranslations.Where(unit => unit.LanguageId == request.Dto.LanguageId)
                .Select(unit => new PrefaceTranslationDto()
                {
                    TranslationId = unit.Id,
                    Content = unit.Content,
                    Language = _iMapper.Map<LanguageListDto>(unit.Language),
                }).Single(),
                InternShipsDtos = x.Internships.Where(intrshp => intrshp.Translations.Any(trnsl => request.Dto.LanguageId == trnsl.LanguageId)).Select(x => new InternShipExportDto()
                {
                    SchoolYear = x.SchoolYear,
                    Locations = _iMapper.Map<IList<LocationDto>>(x.Locations),
                    TrainingType = x.RequiredTrainingType,
                    Translation = x.Translations.Select(trnslDto => new TranslationDto()
                    {
                        TranslationId = trnslDto.Id,
                        TitleContent = trnslDto.TitleContent,
                        Comment = trnslDto.Comment,
                        Description = trnslDto.Description,
                        KnowledgeToDevelop = trnslDto.KnowledgeToDevelop,
                        NeededKnowledge = trnslDto.NeededKnowledge,

                    }).First()
                }).ToList()
            })
            .ToListAsync();


        foreach (var item in units)
        {

        }

        //export? 
        //GenerateWordDoc(units, request.Dto);

        return new List<UnitExportDto>() { };
        //return units;
    }

    //Export logica in private methode en exposed public methode 
    //Roep hier de interface aan 

    public void GenerateWordDoc(List<UnitExportDto> unitExportList, InternshipExportRequestDto requestDto)
    {
        const string templatePath = @"C:\Users\ALFCP98\source\repos\InternRApp\backend\backend\backend\lib\template.docx"; //-> docm
        const string resultPath = @"C:\Users\ALFCP98\source\repos\InternRApp\backend\backend\backend\lib\internships.docx";

        WordprocessingDocument document = WordprocessingDocument.CreateFromTemplate(templatePath);
        var body = document.MainDocumentPart!.Document.Body;
        var allElements = body!.Elements().ToList();

        int altChunckId = 0;
        int index = 0;

        //fetch static content from resource files 
        //change language code depending on request 
        var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.GetName().Name == "WebUI").ToList();
        var langCode = _dbContext.Languages.Where(lang => lang.Id == requestDto.LanguageId).Single().Code;
        ResourceManager rm = new ResourceManager($"WebUI.Resources.{langCode}", Assembly.LoadFile(@$"{assemblies[0].Location}"));

        if (File.Exists(resultPath))
        {
            File.Delete(resultPath);
        }

        Dictionary<string, string> commonReplacements = new Dictionary<string, string>()
                 {
                     {"TEMPLATE_TITLE", rm.GetString("TEMPLATE_TITLE")},
                     {"TEMPLATE_YEAR", requestDto.SchoolYear},
                     {"COMPANY_TITLE", rm.GetString("COMPANY_TITLE")},
                     {"COMPANY_DESCRIPTION", rm.GetString("COMPANY_DESCRIPTION")},
                     //{"COMPANY_VISION_TITLE", rm.GetString("COMPANY_VISION_TITLE")},
                     //{"COMPANY_VISION_DESCRIPTION", rm.GetString("COMPANY_VISION_DESCRIPTION")},
                     //{"COMPANY_VALUES_TITLE", rm.GetString("COMPANY_VALUES_TITLE")},
                     //{"COMPANY_VALUES_DESCRIPTION", rm.GetString("COMPANY_VALUES_DESCRIPTION")},
                     //{"ACADEMICT_TITLE", rm.GetString("ACADEMICT_TITLE")},
                     //{"ACADEMICT_DESCRIPTION", rm.GetString("ACADEMICT_DESCRIPTION")},
                 };

        ReplaceParagraphs(document, allElements, commonReplacements, ref altChunckId, ref index);

        ExtractParagraphs(allElements, "UNIT_TITLE", "UNIT_END", out var unitStartPosition, out var templateUnitParagraphs);

        InsertUnitParagraphs(document, unitExportList, templateUnitParagraphs, unitStartPosition, ref altChunckId, ref index);

        var newElements = body!.Elements().ToList();
        List<string> toDeleteStrings = new List<string>() { "INTERNSHIP_END", "UNIT_END" };
        DeleteParagraphs(newElements, toDeleteStrings);

        //update index table 
        document.MainDocumentPart!.DocumentSettingsPart!.Settings.Append(new UpdateFieldsOnOpen() { Val = true }); //dit update de velden maar toont nog steeds een update dialog
        //dit update de velden maar toont nog steeds een update dialog, elke keer bij openen? 

        RemoveSdt(body);

        // Save result document, not modifying the template
        document.Clone(resultPath);

    }

    private void RemoveSdt(Body body)
    {
        var i = 0;
        foreach (var item in body.Elements())
        {
            if (item is SdtBlock)
            {
                body.RemoveChild(item);

                var sdtBlock = new SdtBlock();
                sdtBlock.InnerXml = GetTOC("Content", 16);
                body.InsertAt(sdtBlock, i);
                body.InsertAfter(new Break() { Type = BreakValues.Page }, sdtBlock);
            }
            i++;
        }
    }
    private string GetTOC(string title, int titleFontSize)
    {
        return $@"<w:sdt>
     <w:sdtPr>
        <w:id w:val=""-493258456"" />
        <w:docPartObj>
           <w:docPartGallery w:val=""Table of Contents"" />
           <w:docPartUnique />
        </w:docPartObj>
     </w:sdtPr>
     <w:sdtEndPr>
        <w:rPr>
           <w:rFonts w:asciiTheme=""minorHAnsi"" w:eastAsiaTheme=""minorHAnsi"" w:hAnsiTheme=""minorHAnsi"" w:cstheme=""minorBidi"" />
           <w:b />
           <w:bCs />
           <w:noProof />
           <w:color w:val=""auto"" />
           <w:sz w:val=""22"" />
           <w:szCs w:val=""22"" />
        </w:rPr>
     </w:sdtEndPr>
     <w:sdtContent>
        <w:p w:rsidR=""00095C65"" w:rsidRDefault=""00095C65"">
           <w:pPr>
              <w:pStyle w:val=""TOCHeading"" />
              <w:jc w:val=""center"" /> 
           </w:pPr>
           <w:r>
                <w:rPr>
                  <w:b /> 
                  <w:color w:val=""2E74B5"" w:themeColor=""accent1"" w:themeShade=""BF"" /> 
                  <w:sz w:val=""{titleFontSize * 2}"" /> 
                  <w:szCs w:val=""{titleFontSize * 2}"" /> 
              </w:rPr>
              <w:t>{title}</w:t>
           </w:r>
        </w:p>
        <w:p w:rsidR=""00095C65"" w:rsidRDefault=""00095C65"">
           <w:r>
              <w:rPr>
                 <w:b />
                 <w:bCs />
                 <w:noProof />
              </w:rPr>
              <w:fldChar w:fldCharType=""begin"" />
           </w:r>
           <w:r>
              <w:rPr>
                 <w:b />
                 <w:bCs />
                 <w:noProof />
              </w:rPr>
              <w:instrText xml:space=""preserve""> TOC \o ""1-3"" \h \z \u </w:instrText>
           </w:r>
           <w:r>
              <w:rPr>
                 <w:b />
                 <w:bCs />
                 <w:noProof />
              </w:rPr>
              <w:fldChar w:fldCharType=""separate"" />
           </w:r>
           <w:r>
              <w:rPr>
                 <w:noProof />
              </w:rPr>
              <w:t>No table of contents entries found.</w:t>
           </w:r>
           <w:r>
              <w:rPr>
                 <w:b />
                 <w:bCs />
                 <w:noProof />
              </w:rPr>
              <w:fldChar w:fldCharType=""end"" />
           </w:r>
        </w:p>
     </w:sdtContent>
  </w:sdt>";
    }

    public string GetCombinedText(IEnumerable<Text> textElements)
    {
        //plak alle text elementen aan elkaar die bij elke paragraaf horen 
        return string.Join("", textElements.Select(t => t.Text)); // IN TERN SHIP TI TLE -> INTERNSHIP_TITLE
    }

    public List<T> Reversed<T>(IList<T> list)
    {
        return Enumerable
            .Range(1, list.Count())
            .Select(i => list[list.Count() - i])
            .ToList();
    }

    public List<OpenXmlElement> CloneELements(List<OpenXmlElement> elements)
    {
        return elements
            .Select(element => element.CloneNode(true))
            .ToList();
    }

    //Get Text elements and replace 
    public void ReplaceParagraphs(WordprocessingDocument document, List<OpenXmlElement> elements, Dictionary<string, string> replacements,
        ref int chunkId, ref int index)
    {
        foreach (var e in elements)
        {
            if (e is Paragraph)
            {
                var p = e as Paragraph;

                var textElements = p.Elements<Run>()
                                   .SelectMany(r => r.Elements<Text>());

                //Misschien eruit halen zodat het herbruikbaarder is?? 
                Replace(document, textElements, replacements, ref chunkId, ref index); // IN TERN SHIP TI TLE -> INTERNSHIP_TITLE -> InternRApp
            }
            index++;
        }
    }

    public void Replace(WordprocessingDocument document, IEnumerable<Text> textElements, Dictionary<string, string> replacements,
        ref int chunkId, ref int index)
    {
        var combinedText = GetCombinedText(textElements);

        //order de keys van groot naar klein om conflicten met eve lange woorden te vermijden
        foreach (var pair in replacements.OrderBy(pair => pair.Key).Reverse())
        {
            //PER PARAGRAAF VERGELIJK MET EEN REVERSED DICTONIARY //check of het template veld overeenkomt met de key
            if (combinedText.Contains(pair.Key)) //INT ERN SHIP_VALUES //INTERNSHIP //values 
            {
                var enumerator = textElements.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    var remainingKey = pair.Key;
                    var correctTextElements = new List<Text>();
                    var exists = true; //vermijd nulpointer error bij laatste moveNext()
                    var matchingChars = 0;

                    // wanneer letter van textElement overeenkomt met dictionary key 
                    //loop over IN TERN SHIP (textElements) 
                    // remaningKey = "INTERNSHIP-COMMENTS-CONTENT"

                    // "1"
                    // enumerator.Current.Text = "INTERNSHIP-COMMENTS-CONTENT "
                    //while (exists && remainingKey.StartsWith(enumerator.Current.Text))


                    // "INTERSHIP"

                    // "IN"
                    // "TERN"
                    // "SHIP"
                    while (exists && (matchingChars = MatchingCharsAt(remainingKey, enumerator.Current.Text)) != 0)
                    {
                        remainingKey = remainingKey.Substring(matchingChars); //check op IINTERNSHIP 

                        correctTextElements.Add(enumerator.Current); //toevoegen van textElements 

                        if (remainingKey.Length == 0) //op eerste T element locatie
                        {
                            //if 
                            if (Regex.IsMatch(pair.Value, "<p>|<bold>|<li>|<a>|<ol>|<i>"))
                            {
                                document.MainDocumentPart!.Document.Body.InsertAt(ChunkMethod(document, pair.Value, ref chunkId), index);
                                correctTextElements[0].Text = "";
                            }
                            else
                            {
                                correctTextElements[0].Text = pair.Value; //Kopieer data naar plaats textElement[0]
                            }

                            for (var i = 1; i < correctTextElements.Count; i++)
                            {
                                correctTextElements[i].Text = ""; //volgende t elementen leeg laten -> later removen
                            }
                        }
                        exists = enumerator.MoveNext();
                    }
                }
            }
        }
    }

    public AltChunk ChunkMethod(WordprocessingDocument document, string html, ref int chunkId)
    {
        chunkId++;
        AltChunk altChunk = new AltChunk();

        //HTML
        AlternativeFormatImportPart chunk = document.MainDocumentPart!.AddAlternativeFormatImportPart(
            AlternativeFormatImportPartType.Html, $"altChunkId{chunkId}"); //this chunk will contain HTML

        using (Stream chunkStream = chunk.GetStream(FileMode.Create, FileAccess.Write))
        {
            using (StreamWriter stringStream = new StreamWriter(chunkStream))
            {
                stringStream.Write(html);
            }

        }
        altChunk.Id = document.MainDocumentPart!.GetIdOfPart(chunk);
        return altChunk;
    }

    public void ExtractParagraphs(IEnumerable<OpenXmlElement> elements, string startSection, string endSection, out int startPosition, out List<OpenXmlElement> extratedParagraphs)
    {
        var position = 0;
        var inSection = false;
        extratedParagraphs = new List<OpenXmlElement>(); //
        startPosition = 0;

        foreach (var e in elements)
        {
            if (e is Paragraph)
            {
                var p = e as Paragraph;
                var textElements = e.Elements<Run>()
                    .SelectMany(r => r.Elements<Text>());

                var text = GetCombinedText(textElements);

                //Wanneer template paragraaf overeenkomt met meegegeven string, houdt positie bij 
                if (text.Contains(startSection))
                {
                    inSection = true;
                    startPosition = position;
                }

                if (text.Contains(endSection))
                {
                    inSection = false;
                }

                if (inSection)
                {
                    extratedParagraphs.Add(p);
                    if (p.Parent != null)
                    {
                        p.Remove();
                    }

                    //copy internships en delete achteraf van template 
                    //verwijder pas wanneer je inInternShip = false 
                    // en verwijder op positie paragraphPosition

                }
            }
            position++;
        }
    }

    public void InsertUnitParagraphs(WordprocessingDocument document, List<UnitExportDto> unitList, List<OpenXmlElement> templateUnitParagraphs,
        int unitStartPosition, ref int chunkId, ref int index)
    {

        //moet ik dat nu nog reversen? in welke volgorde moeten de units komen? 
        var reversedUnits = Reversed(unitList); //units 

        for (var unitIndex = 0; unitIndex < reversedUnits.Count; unitIndex++) //Nieuwe lijst in omgekeerde volgorde 
        {
            var unit = reversedUnits[unitIndex];
            var unitElements = CloneELements(templateUnitParagraphs);

            ReplaceParagraphs(document, unitElements, new Dictionary<string, string>()
                    {
                        {"UNIT_TITLE", unit.Name},
                        {"UNIT_DESCRIPTION", unit.PrefaceDto.Content}, //change 
                    },ref chunkId, ref index);

            ExtractParagraphs(unitElements, "INTERNSHIP_TITLE", "INTERNSHIP_END", out var internshipStartPosition, out var templateInternshipParagraphs);

            unitElements.RemoveRange(internshipStartPosition, templateInternshipParagraphs.Count); //Delete niet ingevulde internship template  

            foreach (var internship in /* unit.InternShipsDtos */ new List<InternShipExportDto>())
            {

                var internshipParagraphs = CloneELements(templateInternshipParagraphs);

                ReplaceParagraphs(document, internshipParagraphs, new Dictionary<string, string>()
                          {
                              {"INTERNSHIP_TITLE", internship.Translation.TitleContent},
                              {"INTERNSHIP_ASSIGNMENT_TITLE", "Description of the assignment"},
                              {"INTERNSHIP_ASSIGNMENT_DESCRIPTION", ""},
                              {"INTERNSHIP_KNOWLEDGE_TITLE", ""},
                              {"INTERNSHIP_KNOWLEDGE_DESCRIPTION", ""},
                              {"INTERNSHIP_KNOWLEDGE_CONTENT", "title"},
                              {"INTERNSHIP_NEED_TO_KNOW_TITLE", "title"},
                              {"INTERNSHIP_NEED_TO_KNOW_DESCRIPTION", "title"},
                              {"INTERNSHIP_NEED_TO_KNOW_CONTENT", "title"},
                              {"INTERNSHIP_LOCATION_TITLE", "title"},
                              {"INTERNSHIP_LOCATION_DESCRIPTION", "title"},
                              {"INTERNSHIP_LOCATION_CONTENT", internship.Locations.ToString()},
                              {"INTERNSHIP_COMMENTS", "title"},
                              {"INTERNSHIP_COMMENTS_CONTENT", "title"},
                          }, ref chunkId, ref index);

                unitElements.InsertRange(internshipStartPosition, internshipParagraphs); //toevoegen van internshipParagraaf lijst in unit paragrafen 

            }

            //add new break
            if (unitIndex != 0)
            {
                unitElements.Add(new Break() { Type = BreakValues.Page });
            }

            //allParagraphs.InsertRange(unitStartPosition, unitParagraphs);  omdat je met gecloned unit lijst werkt kan je de template niet rechtstreeks aanpassen   
            Enumerable.Range(1, unitElements.Count())
                .Select(i => unitElements[unitElements.Count() - i])
                .ToList()
                .ForEach(element =>
                {
                    document.MainDocumentPart.Document.Body.InsertAt(element, unitStartPosition); //toevoegen van unit paragrafen in document 
                });
        }
    }

    public int MatchingCharsAt(string s1, string s2)
    {
        var i = 0;
        while (i < s1.Length && i < s2.Length && s1[i] == s2[i])
        {
            i++;
        }
        return i;
    }

    public void DeleteParagraphs(List<OpenXmlElement> allElements, List<string> toDeleteParagraphs)
    {
        foreach (var e in allElements)
        {
            if (e is Paragraph)
            {
                var textElements = e.Elements<Run>()
                                       .SelectMany(r => r.Elements<DocumentFormat.OpenXml.Wordprocessing.Text>());

                var text = GetCombinedText(textElements);

                foreach (var item in toDeleteParagraphs)
                {
                    if (text.Contains(item))
                    {
                        e.RemoveAllChildren();
                    }
                }
            }
        }
    }

}





