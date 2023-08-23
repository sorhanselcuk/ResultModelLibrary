﻿namespace ResultModelLibrary.Abstract
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
