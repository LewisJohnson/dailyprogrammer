    using System;
    using System.IO;
    using System.Linq;
    
    namespace TweetTweet
    {
    
        internal static class Program
        {
            private static void Main()
            {
                var list = File.ReadAllLines(@"enable1.txt");
                HandleMaker(list);
                Console.WriteLine("\n\n----------------------------------------");
                Console.WriteLine("             B-B-B-BONUS ROUND !        ");
                Console.WriteLine("----------------------------------------");
                HandleMakerBonus(list);
                Console.ReadLine();
            }
    
            private static void HandleMaker(string[] list)
            {
                var atlist = list.Where(word => word.StartsWith("at")).ToList();
                Console.WriteLine("Shortest 10:\n" ); foreach (var item in atlist.GetRange(0, 10))
                    Console.WriteLine(item.Replace("at", "@") + " : " + item);
                Console.WriteLine("\nLongest 10:\n"); foreach (var item in atlist.Skip(Math.Max(0, atlist.Count() - 10)))
                    Console.WriteLine(item.Replace("at", "@") + " : " + item);
            }
    
            private static void HandleMakerBonus(string[] list)
            {
                list.Where(word => word.StartsWith("at")).ToList().ForEach(item => { Console.WriteLine(item.Replace("at", "@") + " : " + item); });
            }
        }
    }
