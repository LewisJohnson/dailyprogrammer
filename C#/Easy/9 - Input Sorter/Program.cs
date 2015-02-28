using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Input_Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            Console.WriteLine("Gimme stuff to sort");
            var input = Console.ReadLine();
            string[] strings = input.Split(' ');

            int[] convertedItems = Array.ConvertAll(strings, int.Parse);

            var list = convertedItems.ToList();
            list.Sort();

            foreach (var Item in list)
            {
                i++;
                Console.WriteLine("List Item {0}: {1}", i, Item);
            }
        }
    }
}
