using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanck___Sum_of_Diagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { 
                                            { 11, 2 ,4}, 
                                            { 4, 5, 6 }, 
                                            { 10, 8,-12 }
                                        };
            ArrayList firstDiagonal = new ArrayList();
            ArrayList secondDiagonal = new ArrayList();

            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < matrix.Length/3; i++)
            {
                firstDiagonal.Add(matrix[i,i]);

                Console.WriteLine("Added to first diagonal : " + matrix[i,i]);
            }

            int k = 0;
            for (int i = matrix.Length/3 - 1; i >= 0; i--)
            {
                secondDiagonal.Add(matrix[i, k]);
                Console.WriteLine("Added to second diagonal : " + matrix[i, k]);
                ++k;
            }


            Console.WriteLine();
            foreach (int item in firstDiagonal)
            {
                firstSum += item;
                Console.WriteLine("Item added to firstSum  : " + item);
            }

            foreach (int item in secondDiagonal)
            {
                secondSum += item;
                Console.WriteLine("Item added to secondSum  : " + item);
            }

            for (int i = 0; i < matrix.Length/3; i++)
            {
                for (int j = 0; j < matrix.Length/3; j++)
                {
                    Console.Write(matrix[i,j] + "-");
                }

                Console.WriteLine();
            }

            Console.WriteLine("First sum = " + firstSum );
            Console.WriteLine("Second Sum = " + secondSum);

            Console.WriteLine("The difference of the diagonals is  : " + Math.Abs((int)(firstSum - secondSum)));

        }
    }
}
