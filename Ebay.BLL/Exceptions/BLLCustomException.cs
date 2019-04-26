using Ebay.Common;
using System;

namespace Ebay.BLL.Exceptions
{
    class BLLCustomException : BaseException
    {
        public BLLCustomException(string message, Exception ex) : base(message,ex){}
        public BLLCustomException(string message) : base(message) { }
    }
}
