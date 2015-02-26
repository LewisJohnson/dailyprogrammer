using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Simple Intrest\n2. Compond Intrest");
            var c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine("Loan Amount");
                    var p = double.Parse(Console.ReadLine());

                    Console.WriteLine("Rate Of Intrest");
                    var r = double.Parse(Console.ReadLine());

                    Console.WriteLine("Loan time");
                    var t = double.Parse(Console.ReadLine());

                    Console.WriteLine(IntrestCalc.Simple(p, r, t));
                    break;

                case 2:
                    break;

                default:
                    break;
            }
        }
    }

    public static class IntrestCalc
    {
        public static double Simple(double Amount, double Intrest, double Time)
        {
            Intrest /=  100;
            return Amount * Intrest * Time;
        }

        public static void Compound()
        {

        }
    }
}
