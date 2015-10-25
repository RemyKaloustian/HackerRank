using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank___PlusMinusRatio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {-4,3,-9,0,4,1};

            double posCounter = 0;
            double negCounter = 0;
            double zeroCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) ++posCounter;
                else if (array[i] < 0) ++negCounter;
                else ++zeroCounter;
            }

            Console.WriteLine(

                                "\n Positive ratio : " + System.Math.Round(posCounter/array.Length , 3) + 
                                "\n Negative Ratio : " +  System.Math.Round(negCounter/array.Length, 3) + 
                                "\n zero ratio : "  + System.Math.Round(zeroCounter/array.Length,3) 
                              );
        }
    }
}
