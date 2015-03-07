using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___Split_me_in_half
{
    using System.Collections;

    internal static class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Add some ints with spaces and stuff");
            string[] splitStrings = Console.ReadLine()?.Split(' ');
            var intArray = Array.ConvertAll(splitStrings, int.Parse);
            var array1 = intArray.Take(intArray.Length / 2).ToArray();
            var array2 = intArray.Skip(intArray.Length / 2).ToArray();

            Console.WriteLine("List 1: {0}\nList 2: {1}", Write(array1), Write(array2));
            Console.ReadLine();
        }

        private static string Write(IEnumerable array)
        {
            return array.Cast<object>().Aggregate("", (current, item) => current + (item + " "));
        }
    }
}