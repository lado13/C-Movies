using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
