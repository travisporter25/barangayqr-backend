namespace BarangayQR.Core.Entities;

public class Search<T> 
{
    public int CurrentPage { get; set; } // The current page number
    public int TotalPages { get; set; } // The total number of pages
    public int PageSize { get; set; } // The number of items per page
    public List<T>? Result { get; set; } // The list of search results

}
