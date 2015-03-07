using System;

namespace Counting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            args = Console.ReadLine().Split(' ');
            var dt = new DateTime(int.Parse(args[2]), int.Parse(args[1]), int.Parse(args[0]));
            var result = dt.Subtract(DateTime.UtcNow);
        }
    }
}

