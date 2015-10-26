using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank___Funny_String
{
    class Program
    {

        static string Funny(string newstr)
        {
            StringBuilder str = new StringBuilder(newstr);
            StringBuilder strreverse = new StringBuilder(newstr);

            for (int i = 0; i < newstr.Length; i++)
            {
                strreverse[i] = str[str.Length - 1 - i];
            }

            Console.WriteLine("Strreverse : " + strreverse);

            for (int i =1; i < str.Length; i++)
            {    
                if (Math.Abs((str[i] - str[i - 1])) != Math.Abs((strreverse[i] - strreverse[i - 1])))
                    return "Not Funny";
            }

            return "Funny";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Funny("acxz"));
        }
    }
}
