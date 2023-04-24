namespace WebUI.Contracts;

public class LanguageFilterAndPaginationDto
{
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public string LanguageCode { get; set; }
}
