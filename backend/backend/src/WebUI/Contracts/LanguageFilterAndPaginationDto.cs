using WebUI.BaseContracts;

namespace WebUI.Contracts;

public class LanguageFilterAndPaginationDto : IPageable
{
    public string LanguageCode { get; set; }
    public int PageIndex { get ; set ; }
    public int PageSize { get; set ; }
}
