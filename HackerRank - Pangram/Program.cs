using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank___Pangram
{
    class Program
    {
        static string IsPangram(string sentence)
        {
            SortedDictionary<char, int> alphabet = new SortedDictionary<char, int>();

            for (char c = 'a'; c < '{'; c++)
            {
                alphabet.Add(c, 0);
            }

            for (int i = 0; i < sentence.Length; i++)
            {
                if (alphabet.ContainsKey(sentence[i]))
                {
                    alphabet[sentence[i]] = 1;
                }
            }

            foreach (KeyValuePair<char,int> entry in alphabet)
            {
                if (entry.Value == 0)
                    return "Not a pangram";
            }

            return "Pangram";

        }//IsPangram()

        static void Main(string[] args)
        {

            Console.WriteLine(IsPangram("We promptly judged antique ivory buckles for the next prize".ToLower() ));

        }
    }
}
