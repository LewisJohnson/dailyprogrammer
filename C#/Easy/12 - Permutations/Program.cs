namespace _12___Permutations
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            var p = new Permute();
            Console.WriteLine("Write a word.");
            var s = Console.ReadLine();
            if (s != null)
            {
                char[] c2 = s.ToCharArray();
                p.Setper(c2);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You messed up. Try again.");
                Console.WriteLine("Write a WORD.");
                s = Console.ReadLine();
            }

            Console.ReadLine();
        }

    }
}
