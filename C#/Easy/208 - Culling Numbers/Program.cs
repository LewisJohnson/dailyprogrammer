using System;
using System.Collections.Generic;
using System.Linq;

namespace _208___Culling_Numbers
{

    static class Program
    {
        static void Main()
        {
            var output = new HashSet<int>();

            try
            {
                 output = new HashSet<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Wrong input, try again.");
                output = new HashSet<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            }


            Console.Write(Environment.NewLine);
            Console.WriteLine("Result: ");
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
