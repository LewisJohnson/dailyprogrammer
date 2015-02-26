using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = 0;
            var result = "";
            Console.WriteLine("How many passwords would you like ?");
            var n = int.Parse(Console.ReadLine());
            Console.Clear();

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("How long do you want your password {0} to be ?" , n);
                var m = int.Parse(Console.ReadLine());
                result += MakePassword(m) + " ";
                Console.Clear();

            }

            string[] rStrings = result.Split(' ');

            foreach (var Item in rStrings)
            {
                r++;
                Console.WriteLine("Password " + r + ": " + Item);
                Console.WriteLine("--------------");
            }

            Console.ReadLine();


        }

        private static string MakePassword(int length)
        {
            var password = "";

            var ran = new Random();
            for (var i = 0; i < length; i++)
            {
                var num = ran.Next(0, 26);
                var let = (char)('a' + num);
                password += let;
            }


            return password;
        }

    }
}
