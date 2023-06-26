namespace BoltBit.Core.Models.Response;

public interface IResponse<T>
{
    bool IsSuccess { get; }
    string Message { get; }
    T Data { get; }
    Exception Exception { get; }
}

public interface IResponse
{
    bool IsSuccess { get; }
    string Message { get; }
    Exception Exception { get; }
}