using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank___Alternating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abaaab";
            int deletionCounter = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    char currentChar = str[i];
                    ++deletionCounter;
                }
            }

            Console.WriteLine("Il faut supprimer " + deletionCounter + " caractères");

        }
    }
}
