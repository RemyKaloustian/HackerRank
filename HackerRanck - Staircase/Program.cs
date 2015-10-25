using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanck___Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please take the height of the staircase");
            int height = Convert.ToInt32(Console.ReadLine());

            int lineCounter = 0;
            int lineLength = 1;

            while (lineCounter < height)
            {
                for (int i = 0; i < lineLength; i++)
                    Console.Write("#");

                Console.WriteLine();
                lineCounter++;
                lineLength++;
            }
        }
    }
}
