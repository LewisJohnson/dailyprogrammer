    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    namespace _207___DNA_Replication
    {
        static class Program
        {
            static void Main()
            {
                var input = Console.ReadLine();
                var output = new StringBuilder();
    
                foreach (var item in input.Where(item => DnaDictionary.ContainsKey(item)))
                {
                    output.Append(DnaDictionary[item] + " ");
                }
    
                ConsoleStuff(input, output.ToString());
            }
    
            static void ConsoleStuff(string input, string output)
        {
            Console.Clear();
            Console.WriteLine("Output: \n");
            Console.WriteLine(input);
            Console.WriteLine(output.ToString());
            Console.ReadKey();
        }
    
            static readonly Dictionary<char, char> DnaDictionary = new Dictionary<char, char>{
                { 'A', 'T' },
                { 'C', 'G' },
                { 'T', 'A' },
                { 'G', 'C' }
            };
        }
    
    
    }
