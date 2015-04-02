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


            long[] chain = new long[long.Parse(Console.ReadLine() + 1)];

            long final = int.Parse(Console.ReadLine());

            MakeSomeTreeChainThing(chain, 1, final);

            foreach (var item in chain)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        private static bool MakeSomeTreeChainThing(long[] chainList, int stepsize, long finalnumber)
        {
            for (var firstIndex = stepsize - 1; firstIndex >= 0; firstIndex--)
            {
                for (var secondIndex = stepsize - 1; secondIndex >= 0; secondIndex--)
                {
                    var curSum = chainList[firstIndex] + chainList[secondIndex];
                    if (curSum <= chainList[stepsize - 1])
                    {
                        break;
                    }
                    if (curSum > finalnumber || (curSum < finalnumber >> (chainList.Length - 1 - stepsize)))
                    {
                        continue;
                    }
                    if (curSum == finalnumber)
                    {
                        for (var fillIndex = stepsize; fillIndex <= chainList.Length; fillIndex++)
                        {
                            chainList[fillIndex] = curSum;
                        }
                        return true;
                    }
                    chainList[stepsize] = curSum;
                    if (stepsize < chainList.Length)
                    {
                        if (MakeSomeTreeChainThing(chainList, stepsize + 1, finalnumber))
                        {
                            return true;
                        }
                    }
                }
            }
            return true;
        }
    }
}
