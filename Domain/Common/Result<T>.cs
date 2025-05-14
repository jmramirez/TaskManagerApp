namespace Domain.Common;

public class Result<T>
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public string? Error { get; }
    public T? Value { get; }

    protected Result(bool isSuccess, T? value, string? error)
    {
        IsSuccess = isSuccess;
        Error = error;
        Value = value;
    }

    public static Result<T> Success(T value) => new(true, value, null);

    public static new Result<T> Failure(string error)
    {
        
    }
    public static implicit operator Result<T>(T value) => Success(value);
}