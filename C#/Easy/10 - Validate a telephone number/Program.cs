using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _10___Validate_a_telephone_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //000 0000 0000
            var r = new Regex(@"\b\d{3}[-.]?\d{4}[-.]?\d{4}\b");
            Console.WriteLine("Input home phone number");
            var n = Console.ReadLine();
            Console.WriteLine("Validating your number....\n");
            Console.WriteLine(r.IsMatch(n) ? "You number is a valid UK home number." : "You number is NOT a valid UK home number.");

            Console.ReadLine();

        }
    }
}
