using Domain.Common;

namespace Domain.Tasks.ValueObjects;

public sealed class TaskTitle : ValueObject
{
    public string Value { get; }

    private TaskTitle(string value)
    {
        Value = value;
    }

    public static Result<TaskTitle> Create(string value)
    {
        if(string.IsNullOrWhiteSpace(value))
            return Result<TaskTitle>.Failure("Title is required");
        
        if(value.Length > 100)
            return Result<TaskTitle>.Failure("Title must be 100 characters or fewer");

        return Result<TaskTitle>.Success(new TaskTitle(value.Trim()));
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public override string ToString() => Value;
}