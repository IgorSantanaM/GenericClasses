using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class FullStackException : Exception
    {
        public FullStackException() : base("Stack is full")
        {
            
        }
        public FullStackException(string exception) : base(exception) 
        {
            
        }
        public FullStackException(string exception, Exception inner) : base(exception, inner)
        {
            
        }
    }
}
