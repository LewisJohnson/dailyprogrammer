using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___Split_me_in_half
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            List<int> List = new List<int>();

            Console.WriteLine("Add some ints with spaces and stuff");
            string[] splitStrings = Console.ReadLine()?.Split(' ');

            Array.ConvertAll(splitStrings[0], int.Parse());
            splitStrings.ToList();
        }
    }

}
