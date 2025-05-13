using Domain.Common;

namespace Domain.Tasks.ValueObjects;

public class TaskId : ValueObject
{
    public Guid Value { get; }

    private TaskId(Guid value)
    {
        Value = value;
    }

    public static TaskId New() => new(Guid.NewGuid());
    
    public static TaskId Create(Guid value) => new(value);
    
    public override string ToString() => Value.ToString();
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}