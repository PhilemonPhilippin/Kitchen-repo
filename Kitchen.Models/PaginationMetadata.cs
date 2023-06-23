
namespace Kitchen.Models;

public class PaginationMetadata
{
    public int PageNumber { get; init; }
    public int PageSize { get; init; }
    public int TotalItemCount { get; init; }
    public int TotalPageCount { get; init; }

    public PaginationMetadata(int pageNumber, int pageSize, int itemCount)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalItemCount = itemCount;
        TotalPageCount = (int)Math.Ceiling(itemCount / (double)pageSize);
    }
}
