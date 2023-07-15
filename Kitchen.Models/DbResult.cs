
namespace Kitchen.Models;
public enum Status
{
    Success,
    NotFound,
    NameConflict
}
public class DbResult<T>
{
    public T? Entity { get; set; }
    public Status Status { get; set; } = Status.Success;
}
