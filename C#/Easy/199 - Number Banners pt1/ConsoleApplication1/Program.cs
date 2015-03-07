using System;
using System.Collections.Generic;
using System.Linq;


namespace NumberBanners
{
    static class Program
    {
        static void Main(string[] args)
        {
            var outputList = new List<List<string>[]>
            {
                LedNumberMaker.CreateNumberList(Console.ReadLine()),
            };
            foreach (var list in outputList.SelectMany(subList => subList))
            {
                foreach (var rarara in list)
                {
                    Console.Write(rarara);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }

    static class LedNumberMaker
    {
        private static readonly List<string>[] BigNumbers =
        {
            new List<string> {" _ ", "   ", " _ ", " _ ", "   ", " _ ", " _ ", " _ ", " _ ", " _ "},
            new List<string> {"| |", "  |", " _|", " _|", "|_|", "|_ ", "|_ ", "  |", "|_|", "|_|"},
            new List<string> {"|_|", "  |", "|_ ", " _|", "  |", " _|", "|_|", "  |", "|_|", " _|"}
        };

        public static List<string>[] CreateNumberList(string numbers)
        {
            var bigNumbers = new[] { new List<string>(), new List<string>(), new List<string>() };
            const int R = 3;

            foreach (var loliwin in numbers)
            {
                for (var i = 0; i < R; i++)
                {
                    bigNumbers[i].Add(BigNumbers[i][Convert.ToInt32(loliwin - '0')]);
                }
            }
            return bigNumbers;
        }
    }
}
