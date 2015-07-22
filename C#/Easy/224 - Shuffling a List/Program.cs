using System;
using System.Collections.Generic;
using System.Linq;

namespace _224___Shuffling_a_List
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Shuffle(Console.ReadLine());
            Console.ReadLine();
        }

        private static void Shuffle(string shuffle)
        {
            var s = shuffle.Split(' ');
            var r = new Random();
            var uv = Enumerable.Repeat(-1, s.Length).ToArray();
            var si = -1;
            var l = new List<string>();

            for (var i = 0; i < s.Length; i++)
            {
                var unused = false;
                while (!unused)
                {
                    si = r.Next(s.Length);
                    if (!uv.Contains(si))
                    {
                        uv[i] = si;
                        unused = true;
                    }
                }
                l.Add(s[si]);
            }
            Console.WriteLine(Environment.NewLine);
            foreach (var item in l)
            {
                Console.Write(item + " ");
            }
        }
    }

}
