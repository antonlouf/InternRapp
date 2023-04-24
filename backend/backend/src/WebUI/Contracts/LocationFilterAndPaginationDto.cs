namespace WebUI.Contracts;

public class LocationFilterAndPaginationDto
{
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public string City { get; set; }
}
