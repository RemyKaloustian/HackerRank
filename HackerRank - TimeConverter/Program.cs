using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank___TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt =  DateTime.Parse("07:45 PM");

            Console.WriteLine(dt.ToString("HH:mm"));
        }
    }
}
