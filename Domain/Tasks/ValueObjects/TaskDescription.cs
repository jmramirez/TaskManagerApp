using Domain.Common;

namespace Domain.Tasks.ValueObjects;

public sealed class TaskDescription : ValueObject
{
    public string Value { get; }

    private TaskDescription(string value)
    {
        Value = value;
    }

    public static Result<TaskDescription> Create(string value)
    {
        var trimmedValue = value?.Trim() ?? string.Empty;
        
        if(trimmedValue.Length > 500)
            return Result<TaskDescription>.Failure("Description must be 500 characters or fewer");

        return Result<TaskDescription>.Success(new TaskDescription(trimmedValue));
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public override string ToString() => Value;
}