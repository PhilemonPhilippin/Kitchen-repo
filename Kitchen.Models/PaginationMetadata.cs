
namespace Kitchen.Models;

public class PaginationMetadata
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalItemCount { get; set; }
    public int TotalPageCount { get; set; }

    public PaginationMetadata(int pageNumber, int pageSize, int itemCount)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalItemCount = itemCount;
        TotalPageCount = (int)Math.Ceiling(itemCount / (double)pageSize);
    }
}
