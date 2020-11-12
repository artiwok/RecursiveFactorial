using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    class Program
    {
        static int Factorial(int x)
        {
            if (x == 0)
                return 1;

            int result = x;

            result *= Factorial(x - 1);

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(7));
        }
    }
}
