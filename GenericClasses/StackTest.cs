using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class StackTest
    {
        private static double[] doubleElements = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
        private static int[] intElements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        private static Stack<double> doubleStack;
        private static Stack<int> intStack;
        public static void Main(string[] args)
        {
            doubleStack = new Stack<double>(5);
            intStack = new Stack<int>(10);

            TestPush("doubleStack", doubleStack, doubleElements);
            TestPop("doubleStack", doubleStack);
            TestPush("intStack", intStack, intElements);
            TestPop("intStack", intStack);

        }
        private static void TestPush<T>(string name, Stack<T> stack, IEnumerable<T> elements)
        {
            try
            {
                Console.WriteLine("\nPushing elements onto" + name);

                foreach (var element in elements)
                {
                    Console.WriteLine("{0}", element);
                    stack.Push(element);
                }
            } catch (FullStackException exception)
            {
                Console.Error.WriteLine();
                Console.Error.WriteLine("Message: " + exception.Message);
                Console.Error.WriteLine(exception.StackTrace);
            }
        }
        private static void TestPop<T>(string name, Stack<T> stack)
        {
            try
            {
                Console.WriteLine("\nPushing elements onto " + name);
                T popValue;

                while (true)
                {
                    popValue = stack.Pop();
                    Console.WriteLine("{0}", popValue);
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine();
                Console.Error.WriteLine("Message: " + exception.Message);
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

    }
}
