using System;

namespace Entities.Shared;

public abstract class Response<T>
{
    public string Msg { get; set; } = "";

    public bool IsSuccess { get; set; }

    public T? Data { get; set; }
}

public class ResponseBuilder<T> : Response<T>
{
    public ResponseBuilder()
    {
    }

    public ResponseBuilder(string msg, bool isSuccess, T data)
    {
        this.Msg = msg;
        base.IsSuccess = isSuccess;
        this.Data = data;
    }

    public ResponseBuilder<T> WithMsg(string msg)
    {
        this.Msg = msg;
        return this;
    }

    public ResponseBuilder<T> WithData(T data)
    {
        this.Data = data;
        return this;
    }

    public ResponseBuilder<T> WithSuccess(bool success = true)
    {
        base.IsSuccess = success;
        return this;
    }

    public static Response<T> Success()
    {
        return new ResponseBuilder<T>().WithSuccess(true);
    }

    public static Response<T> Success(string msg)
    {
        return new ResponseBuilder<T>()
            .WithSuccess(true)
            .WithMsg(msg);
    }

    public static Response<T> Fail(string msg)
    {
        return new ResponseBuilder<T>()
            .WithSuccess(false)
            .WithMsg(msg);
    }

    public static Response<T> Error(Exception exception)
    {
        return new ResponseBuilder<T>()
            .WithSuccess(false)
            .WithMsg(exception.Message);
    }
}