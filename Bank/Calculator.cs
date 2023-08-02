using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public static class Calculator
    {
        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num2 * num1);
        }

        public static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
