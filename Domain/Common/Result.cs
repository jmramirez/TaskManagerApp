using System.Diagnostics.Contracts;

namespace Domain.Common;

public class Result
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public string? Error { get; }

    protected Result(bool isSuccess, string? error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }

    public static Result Success() => new(true, null);

    public static Result Failure(string error)
    {
        if(string.IsNullOrWhiteSpace(error))
            throw new AbandonedMutexException(nameof(error));
        return new(false, error);
    }
}