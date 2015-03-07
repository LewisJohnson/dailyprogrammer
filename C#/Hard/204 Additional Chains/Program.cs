using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204_Additional_Chains
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Initial Number");
            var initial = int.Parse(Console.ReadLine());

            Console.WriteLine("Final Number");
            var final = int.Parse(Console.ReadLine());

            ChainMeUp(initial, final);

        }

        private static void ChainMeUp(int initial, int final)
        {
            var wickedNumberList = new List<int>();
            for (int i = 0; i < final; i++)
            {
                
            }
        }
    }
}
