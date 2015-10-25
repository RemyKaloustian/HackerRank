using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank___Library_Fine
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime scheduledReturn = DateTime.ParseExact("6 6 2015", "d M yyyy", System.Globalization.CultureInfo.InvariantCulture);

            DateTime actualReturn = DateTime.ParseExact("9 6 2015", "d M yyyy", System.Globalization.CultureInfo.InvariantCulture);

            if(actualReturn < scheduledReturn)
                Console.WriteLine("Fine is 0.");

            else if(actualReturn.Day > scheduledReturn.Day && actualReturn.Month == scheduledReturn.Month && actualReturn.Year == scheduledReturn.Year)
                Console.WriteLine("Fine is " +(int)( 15 * (actualReturn.Day - scheduledReturn.Day)));

            else if (actualReturn.Month > scheduledReturn.Month && actualReturn.Year == scheduledReturn.Year)
                Console.WriteLine("Fine is " + (int)(500 * actualReturn.Month - scheduledReturn.Month));

            else if (actualReturn.Year > scheduledReturn.Year)            
                Console.WriteLine("Fine is 10000 motherfucker");
            

        }
    }
}
