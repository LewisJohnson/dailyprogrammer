using System;
using System.Linq;

//Using simple LINQ techniques.

namespace _16___StringRemoval
{
    static class Program
    {
        static void Main(string[] args)
        {
        }

        private static string Remove(string str1, string str2){
            return new string(str1.ToCharArray().Where(c => str2.IndexOf(c) == -1).ToArray());}

    }
}
