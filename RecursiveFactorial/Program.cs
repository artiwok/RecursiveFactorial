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
            {
                return 1;
            }    

            return x *= Factorial(x - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(4));
        }
    }
}
