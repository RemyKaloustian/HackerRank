using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanck___Gemstones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rocks = new List<string>();
            rocks.Add("abcdde");
            rocks.Add("baccd");
            rocks.Add("eeabg");

            Dictionary<char, bool> stones = new Dictionary<char, bool>();

            char c = 'a';
            //stones.Add(c,false);

            for (int i = 0;  i < 27; ++i)
            {
                bool isGem = true;
                stones.Add(c, false);
                
                
                foreach (string rock in rocks)
                {
                    if (!rock.Contains(c))
                        isGem = false;
                }

                if (isGem)
                    stones[c] = true;
                
                c = ++c;
                   
            }

            Console.WriteLine("These are the gems : ");

            foreach (KeyValuePair<char, bool> item in stones)
            {
                if(item.Value)
                    Console.WriteLine(item.Key);
            }


        }
    }
}
