﻿namespace ResultModelLibrary.Abstract
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
