using System;

namespace AppKeep.Domain
{
    public class BoolResult
    {
        public bool Result { get; set; }
        public string Message { get; set; }

        public BoolResult()
        {

        }

        public BoolResult(bool result, string message)
        {
            Result = result;
            Message = message;
        }

        public static implicit operator BoolResult(bool v)
        {
            throw new NotImplementedException();
        }
    }

    public class DataResult<T> : BoolResult
    {
        public T Data { get; set; }
        public bool HasChange { get; set; } = true;
    }
}