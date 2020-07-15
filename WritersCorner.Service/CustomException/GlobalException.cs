using System;

namespace WritersCorner.Service.CustomException
{
    public class GlobalException : Exception
    {
        public GlobalException()
        {

        }

        public GlobalException(string message)
            : base(message)
        {

        }
    }
}
