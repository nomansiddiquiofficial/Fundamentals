using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public delegate void Calculation(int a, int b);
    internal class CustomMath
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("The result of a and b is:" +result);
        }

        public static void Divide(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("The result of a and b is: " + result);
        }
    }
}
