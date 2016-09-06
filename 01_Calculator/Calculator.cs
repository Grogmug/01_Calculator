using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Calculator
{
    internal class Calculator
    {
        public static int Add(int x,int y)
        {
            return x + y;
        }

        public static int AddString(string x, string y)
        {
            return Int32.Parse(x) + Int32.Parse(y);
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Sum(int[] s)
        {
            int sumResult = 0;
           for(int i = 0; i < s.Length; i++)
            {
                sumResult += s[i];
            }
            return sumResult;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Power(double x, double y)
        {
            return (int)Math.Pow(x, y);
        }

        public static int Factorial(int x)
        {
            int facResult = 1;
           

            if (x == 0) return 1;

            for(int i = x; i > 0; i--)
            {
                facResult *= i;
            }
            return facResult;
        }
    }
}
