using Domain.Common;

namespace Domain.Tasks.ValueObjects;

public sealed class DueDate : ValueObject
{
    public DateTime Value { get; }

    private DueDate(DateTime value)
    {
        Value = value;
    }

    public static Result<DueDate> Create(DateTime value, DateTime now)
    {
        if (value <= now)
        {
            return Result<DueDate>.Failure("Due date must be in the future");
        }
        return Result<DueDate>.Success(new DueDate(value));
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public override string ToString() => Value.ToString("0");
}