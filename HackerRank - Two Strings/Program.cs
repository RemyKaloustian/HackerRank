using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank___Two_Strings
{
    class Program
    {
        static string firstWord = "hi".ToLower();
        static string secondWord = "World".ToLower();

        static List<string> firstWordSubStr = new List<string>();
        static List<string> secondWordSubStr = new List<string>();

        static void fillSubStrings(string word, List<string> sbStr)
        {
            StringBuilder tempWord;
            int sindex = 1;

            for (int i = 0; i < word.Length; i++)
            {
                tempWord = new StringBuilder(word[i].ToString());
                sbStr.Add(tempWord.ToString());


                for (int j = sindex; j < word.Length; j++)
                {
                    tempWord.Append(word[j].ToString());
                    sbStr.Add(tempWord.ToString());
                }

                sindex++;
            }

        }//fillSubStrings()

        static bool isContained()
        {
            foreach (string item in firstWordSubStr)
            {
                foreach (string item2 in secondWordSubStr)
                {
                    if (item.Equals(item2))
                        return true;
                }
            }

            return false;
        }


        static void Main()
        {

            fillSubStrings(firstWord, firstWordSubStr);

            foreach (string item in firstWordSubStr)
            {
                Console.WriteLine("-- "+ item);
            }

            fillSubStrings(secondWord, secondWordSubStr);


            foreach (string item in secondWordSubStr)
            {
                Console.WriteLine("-- " + item);
            }

            bool yo = isContained();

            if (yo) Console.WriteLine("YEEEEEEEEEEEEEEEEEEEEEESssssssssssssssssss !!!!!!!!!!!!!!");
            else
                Console.WriteLine("NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO.....");

        }
    }
}
