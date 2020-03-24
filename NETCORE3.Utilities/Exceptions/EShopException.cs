using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE3.Utilities.Exceptions
{
    public class EShopException : Exception
    {
        public EShopException()
        {

        }

        public EShopException(string mesaage) : base(mesaage)
        {

        }

        public EShopException (string message, Exception inner) : base(message, inner)
        {

        }
    }
}
