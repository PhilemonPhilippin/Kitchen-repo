
namespace Kitchen.Models;
public enum Status
{
    Success,
    NotFound,
    NameConflict
}
public record DbResult<T> 
{
    public T? Entity { get; init; }
    public Status Status { get; init; } = Status.Success;
}