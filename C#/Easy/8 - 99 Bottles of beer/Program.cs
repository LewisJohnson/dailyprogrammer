using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We could have used a cursor for extra credit but merh..
//Here it is

/*

for (int i = 0; i < 100; ++i)
        {
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r{0}%   ", i);
        }

*/

namespace _8___99_Bottles_of_beer
{
internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 99; i > -1; i--)
        {
            if (i == 0)
            {
                Console.Write("\n\n------------------------------------------------------\n\n");
                Console.Write("No more bottles of beer on the wall, no more bottles of beer. \nGo to the store and buy some more, 99 bottles of beer on the wall.\n");
            }
            else if (i == 1)
            {
                Console.Write(
                    "{0} bottles of beer on the wall, {0} bottles of beer. \nTake one down and pass it around, no more bottles of beer on the wall.", i);

            }
            else
            {
                Console.Write(
                    "{0} bottles of beer on the wall, {0} bottles of beer. \n"
                    + "Take one down and pass it around, {1} bottles of beer on the wall.",
                    i,
                    i - 1);

                Console.Write("\n\n");
            }
        }
    }
}
}

