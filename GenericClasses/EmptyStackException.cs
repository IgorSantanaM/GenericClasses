using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class EmptyStackException : Exception
    {
        public EmptyStackException() : base("Stack is empty")
        {

        }
        public EmptyStackException(string exception) : base(exception)
        {

        }
        public EmptyStackException(string exception, Exception inner) : base(exception, inner)
        {

        }
    }
}
