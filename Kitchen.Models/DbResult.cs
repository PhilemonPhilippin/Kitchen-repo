namespace Kitchen.Models;
public enum Status
{
    Success,
    NotFound,
    NameConflict,
    Error
}

public class DbResult<T>
{
    public Status Status { get; init; } = Status.Success;
    public T? Entity { get; init; }
}