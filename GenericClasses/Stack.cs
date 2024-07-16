using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class Stack<T>
    {
        private int top;
        private T[] elements;

        public Stack() 
            : this(10) 
        {
            
        }
        public Stack(int stackSize)
        {
            if (stackSize > 0)
                elements = new T[stackSize];
            else
                throw new ArgumentException("Stack size must be positive");

            top--;
        }
        public void Push(T pushValue)
        {
            if (top == elements.Length - 1)
                throw new FullStackException(string.Format("Stack is full, cannot push {0}", pushValue));

            top++;
            elements[top] = pushValue;
        }
        public T Pop()
        {
            if (top < 0)
                throw new EmptyStackException("Stack is empty, cannot pop");

            --top; 
            return elements[top+1];
        }
    }
}
