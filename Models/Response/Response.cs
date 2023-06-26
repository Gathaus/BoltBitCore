namespace BoltBit.Core.Models.Response;

public class Response<T> : IResponse<T>
{
    public bool IsSuccess { get; private set; }
    public string Message { get; private set; }
    public T Data { get; private set; }
    public Exception Exception { get; private set; }

    public static Response<T> Success(T data)
    {
        return new Response<T> {IsSuccess = true, Data = data};
    }

    public static Response<T> Fail(string message, Exception exception = null)
    {
        return new Response<T> {IsSuccess = false, Message = message, Exception = exception};
    }
}

public class Response : IResponse
{
    public bool IsSuccess { get; private set; }
    public string Message { get; private set; }
    public Exception Exception { get; private set; }

    public static Response Success()
    {
        return new Response {IsSuccess = true};
    }

    public static Response Fail(string message, Exception exception = null)
    {
        return new Response {IsSuccess = false, Message = message, Exception = exception};
    }
}