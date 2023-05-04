﻿using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Resources;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using backend.Application.InternShips.Common;
using backend.Application.InternShips.Queries.GetAllInternShips;
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

        //if (string.IsNullOrEmpty(request.Dto.SchoolYear) || request.Dto.LanguageId == 0) //verder uitwerken 
        //{
        //    return new List<UnitExportDto>();
        //}

        //&& unit.InternShips.All(intrShps => intrShps.Translations.Any(trnsl => request.Dto.LanguageId == trnsl.LanguageId))

        //Filter on Units and only the internships who have a translation language of request language 
        var units = await _dbContext.Departments
            .Where(unit => (request.Dto.UnitIds == null || request.Dto.UnitIds.Count == 0 || request.Dto.UnitIds.Contains(unit.Id)) 
            && unit.InternShips.Any(intrShps => intrShps.Translations.Any(trnsl => request.Dto.LanguageId == trnsl.LanguageId)))
            .Select(x => new UnitExportDto()
            {
                Name = x.Name,
                InternShipsDtos = x.InternShips.Where(intrshp => intrshp.Translations.Any(trnsl => request.Dto.LanguageId == trnsl.LanguageId)).Select(x => new InternShipExportDto()
                {
                    SchoolYear = x.SchoolYear,
                    Location = _iMapper.Map<LocationDto>(x.Location),
                    TrainingType = x.RequiredTrainingType,
                    Translation = x.Translations.Select(x=>new TranslationDto()
                    {
                        Comment = x.Comment,
                        Content=x.Content,
                        Description = x.Description,
                        Id = x.Id,
                        InternShipId = x.InternShipId,
                        KnowledgeToDevelop=x.KnowledgeToDevelop,
                        NeededKnowledge= x.NeededKnowledge,
                        TitleContent=x.TitleContent,

                    }).First()
                }).ToList()
            }).ToListAsync();
                    //.Where(unit => request.Dto.UnitIds == null || request.Dto.UnitIds.Count == 0 || request.Dto.UnitIds.Contains(unit.Id) //als er geen meegegeven wordt, toon dan alle
                    //&& unit.InternShips.All(intrShps => intrShps.Translations.Any(trnsl => request.Dto.LanguageId == trnsl.LanguageId)));

        //var units = from deps in _dbContext.Departments.Where(x => request.Dto.UnitIds == null || request.Dto.UnitIds.Count == 0 || request.Dto.UnitIds.Contains(x.Id))
        //            join intrshps in _dbContext.InternShips
        //            on deps.Id equals intrshps.UnitId
        //            join trnsl in _dbContext.Translations.Where(x => x.LanguageId == request.Dto.LanguageId)
        //            on intrshps.Id equals trnsl.InternShipId
        //            into trnsl2 
        //            select new UnitExportDto()
        //            {
        //                Name = deps == null ? null : deps.Name,
        //                InternShipsDtos = trnsl2.Select(x => new InternShipExportDto()
        //                {

        //                    Translation = new TranslationDto()
        //                    {

        //                        Content = x.Content,
        //                    },
        //                    //SchoolYear = x.InternShip.SchoolYear
        //                }).ToList()
        //            };

        //var test = units.ToList();

                    //Geef de unit waarvan de unit met internships met zijn translaties overeenkomt met al 
                    //mss selecten omdat unit gewijzigd moet worden -> filtered op intrnshps 

                    //.Include(unit => unit.InternShips)
                    //.ThenInclude(x => x.Translations)
                    //.ToListAsync();

                    /*
                    .Select(unit => new UnitExportDto()
                    {
                        Name = unit.Name,
                        InternShipsDtos = unit.InternShips

                        //.Where(internship => internship.SchoolYear == request.Dto.SchoolYear)

                        .Select(internship =>
                             new InternShipExportDto() //per internships?
                             {
                                 SchoolYear = internship.SchoolYear,
                                 Location = new LocationDto()
                                 {
                                     id = internship.Location.Id,
                                     city = internship.Location.City,
                                     zipcode = internship.Location.ZipCode,
                                     streetname = internship.Location.StreetName,
                                     housenumber = internship.Location.HouseNumber,
                                 },
                                 TrainingType = internship.RequiredTrainingType,
                                 Translation = internship.Translations
                                 .Where(trnsl => trnsl.Language.Id == request.Dto.LanguageId)
                                 .Select(trnsl => new TranslationDto()
                                 {
                                     Id = trnsl.Id,
                                     //Language = new Lang x.Translations.FirstOrDefault(y => y.Language.Id == request.Dto.LanguageId).LanguageId
                                     //Content = internship.Translations.First(trnsl => trnsl.Language.Id == request.Dto.LanguageId).Content
                                 }).Single()
                             }
                         ).ToList()
                    }).ToListAsync();

                    */



        foreach (var item in units)
        {

        }





        //var p = _dbContext.Departments.Where(x => x.InternShips.Any(y => request.Dto.SchoolYear.Contains(y.SchoolYear)));

        //_dbContext.Departments.Select(x => new UnitExportDto())

        //}).ToListAsync(); //--->werkende versie
        //var units = internShips
        //   .GroupBy(x => x.Unit, new UnitEqualityComparer())
        //   .ToList();

        // 


        //var internShips = _dbContext.InternShips.AsQueryable();

        //    internShips = internShips.Include(x => x.Translations.Where(y => y.LanguageId == request.Dto.LanguageId))
        //    .Include(z => z.Unit);
        ////liever als laatst doen en op unit -> internship 

        //if (request.Dto.UnitId != null || request.Dto.UnitId.Any())
        //{
        //    internShips = internShips.Where(internschip => request.Dto.UnitId.Contains(internschip.UnitId));
        //}

        //var internshipsQuery = await internShips.ToListAsync();



        //Filter opbouwen van Departments to UnitExportDto 
        //var units = _dbContext.Departments.AsQueryable();

        ////Fix wanneer unitId leeg is 

        //if (request.Dto.UnitId != null || request.Dto.UnitId.Any())
        //{
        //    units = units.Include(unit => unit.InternShips.Where(internschip => request.Dto.UnitId.Contains(internschip.UnitId)));
        //}

        //var unitsQuery = await units.ToListAsync();



        //units.Include(q => q.)

        //.Where(internschip => (request.Dto.UnitId == null || request.Dto.UnitId.Count == 0 || request.Dto.UnitId.Contains(internschip.UnitId))
        //    && (request.Dto.SchoolYear == null || request.Dto.SchoolYear.Count == 0 || request.Dto.SchoolYear.Contains(internschip.SchoolYear))
        //    && (request.Dto.LanguageId == null || request.Dto.LanguageId.Count == 0 || internschip.Translations.Any(trnsl => request.Dto.LanguageId.Contains(trnsl.LanguageId))))
        //    .ProjectTo<InternShipExportDto>(_iMapper.ConfigurationProvider) // -> Filtered internships 
        //    .ToListAsync();

        //maak compare methode in DepartmentDTO klasse
        //var units = internShips
        //    .Select(y => new InternShipExportDto
        //    {
        //        Department = y.Department,
        //        Location = y.Location,
        //        SchoolYear = y.SchoolYear,
        //        TrainingType = y.TrainingType,
        //        Translations = y.Translations,
        //        Translation = new TranslationDto
        //        {
        //            Content = y.Translations.Where(trnsl => request.Dto.LanguageId.Contains(trnsl.Language.Id))

        //        }
        //    })
        //    .GroupBy(x => x.Department, new UnitEqualityComparer())
        //    x => x, 
        //    (key, values) => new UnitExportDto
        //    {
        //        Name = key.Name,
        //        InternShips = values
        //            .Select(internShip => _iMapper.Map<InternShip, InternShipExportDto>(internShip))
        //            .AsEnumerable()
        //    }, new UnitEqualityComparer())

        //    .ToList();


        return new List<UnitExportDto> { };


    }
}
public class UnitEqualityComparer : IEqualityComparer<DepartmentDto>
{
    public bool Equals(DepartmentDto x, DepartmentDto y)
    {
        if (x == null || y == null)
        {
            return false;
        }
        return x.Id == y.Id;
    }

    public int GetHashCode([DisallowNull] DepartmentDto obj)
    {
        return obj.Id.GetHashCode();
    }
}

//Export logica in private methode en exposed public methode 
//Roep hier de interface aan 

public class Exporting
{
    public void GenerateWordDoc(List<UnitExportDto> unitExportList, InternshipExportRequestDto requestDto)
    {
        const string templatePath = @"C:\Users\ALFCP98\source\repos\InternRApp\backend\backend\backend\lib\template.docx"; //-> docm
        const string resultPath = @"C:\Users\ALFCP98\source\repos\InternRApp\backend\backend\backend\lib\internships.docx";
        const string resultPath2 = @"C:\Users\ALFCP98\source\repos\HelloWorld\HelloWorld\bin\Debug\net6.0\OpenXmlExample2.docx";

        WordprocessingDocument document = WordprocessingDocument.CreateFromTemplate(templatePath);

        var body = document.MainDocumentPart!.Document.Body;
        var allElements = body!.Elements().ToList();

        //fetch data from Resource files 
        //change language code depending on request 
        var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.GetName().Name == "WebUI").ToList();
        ResourceManager rm = new ResourceManager($"WebUI.Resources.nl", Assembly.LoadFile(@$"{assemblies[0].Location}"));


        if (File.Exists(resultPath))
        {
            File.Delete(resultPath);
        }

        Dictionary<string, string> commonReplacements = new Dictionary<string, string>()
                 {
                     {"TEMPLATE_TITLE", rm.GetString("TEMPLATE_TITLE")},
                     {"TEMPLATE_YEAR", "2022-2023"},
                     {"COMPANY_TITLE", rm.GetString("COMPANY_TITLE")},
                     {"COMPANY_DESCRIPTION", rm.GetString("COMPANY_DESCRIPTION") },
                     {"COMPANY_VISION_TITLE", rm.GetString("COMPANY_VISION_TITLE")},
                     {"COMPANY_VISION_DESCRIPTION", rm.GetString("COMPANY_VISION_DESCRIPTION")},
                     {"COMPANY_VALUES_TITLE", rm.GetString("COMPANY_VALUES_TITLE")},
                     {"COMPANY_VALUES_DESCRIPTION", rm.GetString("COMPANY_VALUES_DESCRIPTION")},
                     {"ACADEMICT_TITLE", rm.GetString("ACADEMICT_TITLE")},
                     {"ACADEMICT_DESCRIPTION", rm.GetString("ACADEMICT_DESCRIPTION")},
                 };

        ReplaceParagraphs(allElements, commonReplacements);

        ExtractParagraphs(allElements, "UNIT_TITLE", "UNIT_END", out var unitStartPosition, out var templateUnitParagraphs);

        InsertUnitParagraphs(body, unitExportList, templateUnitParagraphs, unitStartPosition);

        var newElements = body!.Elements().ToList();
        List<string> toDeleteStrings = new List<string>() { "INTERNSHIP_END", "UNIT_END" };
        DeleteParagraphs(newElements, toDeleteStrings);

        //update index table 
        document.MainDocumentPart!.DocumentSettingsPart!.Settings.Append(new UpdateFieldsOnOpen() { Val = true }); //dit update de velden maar toont nog steeds een update dialog
        //dit update de velden maar toont nog steeds een update dialog, elke keer bij openen? 

        RemoveSdt(body);

        // Save result document, not modifying the template
        document.Clone(resultPath);

        //File.Copy(resultPath, resultPath2);
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
                //body.InsertAfter(new Break() { Type = BreakValues.Page }, sdtBlock);
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

    public string GetCombinedText(IEnumerable<DocumentFormat.OpenXml.Wordprocessing.Text> textElements)
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
    public void ReplaceParagraphs(List<OpenXmlElement> elements, Dictionary<string, string> replacements)
    {
        foreach (var e in elements)
        {
            if (e is Paragraph)
            {
                var p = e as Paragraph;

                var textElements = p.Elements<Run>()
                                   .SelectMany(r => r.Elements<DocumentFormat.OpenXml.Wordprocessing.Text>());

                //Misschien eruit halen zodat het herbruikbaarder is?? 
                Replace(textElements, replacements); // IN TERN SHIP TI TLE -> INTERNSHIP_TITLE -> InternRApp
            }
        }
    }

    public void Replace(IEnumerable<DocumentFormat.OpenXml.Wordprocessing.Text> textElements, Dictionary<string, string> replacements)
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
                    var correctTextElements = new List<DocumentFormat.OpenXml.Wordprocessing.Text>();
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
                            correctTextElements[0].Text = pair.Value; //Kopieer data naar plaats textElement[0]
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
                    .SelectMany(r => r.Elements<DocumentFormat.OpenXml.Wordprocessing.Text>());

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

    public void InsertUnitParagraphs(BodyType body, List<UnitExportDto> unitList, List<OpenXmlElement> templateUnitParagraphs, int unitStartPosition)
    {

        /* foreach (var group in UnitList)
         {
             var unit = group.Key;
             foreach (var internShip in group)
             {

             }
         } */

        //moet ik dat nu nog reversen? in welke volgorde moeten de units komen? 
        var reversedUnits = Reversed(unitList); //units 

        for (var unitIndex = 0; unitIndex < reversedUnits.Count; unitIndex++) //Nieuwe lijst in omgekeerde volgorde 
        {
            var unit = reversedUnits[unitIndex];
            var unitElements = CloneELements(templateUnitParagraphs);

            ReplaceParagraphs(unitElements, new Dictionary<string, string>()
                    {
                        {"UNIT_TITLE", unit.Name},
                        {"UNIT_DESCRIPTION", unit.Name}, //change 
                    });

            ExtractParagraphs(unitElements, "INTERNSHIP_TITLE", "INTERNSHIP_END", out var internshipStartPosition, out var templateInternshipParagraphs);

            unitElements.RemoveRange(internshipStartPosition, templateInternshipParagraphs.Count); //Delete niet ingevulde internship template  

            foreach (var internship in /* unit.InternShipsDtos */ new List<InternShipExportDto>())
            {

                var internshipParagraphs = CloneELements(templateInternshipParagraphs);

                ReplaceParagraphs(internshipParagraphs, new Dictionary<string, string>()
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
                              {"INTERNSHIP_LOCATION_CONTENT", internship.Location.ToString()},
                              {"INTERNSHIP_COMMENTS", "title"},
                              {"INTERNSHIP_COMMENTS_CONTENT", "title"},
                          });

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
                    body.InsertAt(element, unitStartPosition); //toevoegen van unit paragrafen in document 
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

