namespace CourseLibrary.API.Parameters;

public class AuthorsResourceParameters
{
    private int _pageSize = 10;
    private const int maxPageSize = 20;
    public string? MainCategory { get; set; }
    public string? SearchQuery { get; set; }

    public int PageNumber { get; set; } = 1;

    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = (value > maxPageSize)? maxPageSize: value;
    }

    public string OrderBy { get; set; } = "Name";
}   