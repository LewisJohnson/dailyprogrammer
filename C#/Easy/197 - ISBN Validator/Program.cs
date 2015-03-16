    using System;
    
    internal static class Program
    {
        private static void Main()
        {
            var isbn = Console.ReadLine();
            var total = 0;
            var cou1 = 1;
            const int cou2 = 11;
            foreach (var t in isbn)
            {
                total = total + ((cou2 - cou1) * Convert.ToInt32(t));
                cou1++;
            }
            Console.WriteLine((total % 11) == 0 ? "Valid." : "Not even.");
        }
    }

