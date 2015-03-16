using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly_Dates
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("First Date please.");
            var date1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Second Date please.");
            var date2 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(date1.Month + date1.Day + date1.Year + "-" + date2.Month + date2.Day + date2.Year);

            Console.ReadLine();
        }
    }
}
