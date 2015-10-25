using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank___Factorial
{
    class Program
    {
        static double Factorial(int nb)
        {
            if (nb == 1)
                return 1;
            else
                return nb * Factorial(nb - 1);

        }

        static void Main(string[] args)
        {
            Console.WriteLine(  Factorial(25));
        }
    }
}
