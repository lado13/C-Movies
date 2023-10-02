using System;

namespace Movies
{
    internal class MetodsException : ApplicationException
    {
        string _message;
        public MetodsException()
        {
            _message = "Something are wrong !!!";
        }
        public override string Message => _message;
    }
}
