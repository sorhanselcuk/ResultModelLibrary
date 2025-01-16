using System;

namespace ResultModelLibrary.Concrete
{
    public class DefaultDataResult<T> : DataResult<T>
    {
        public DefaultDataResult(string message): base(Activator.CreateInstance<T>(), false, message)
        {

        }
    }
}
