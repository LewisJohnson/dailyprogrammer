using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Reverse_List
{
    //Soultion from /u/emcoffey3

    static class Program
    {
        static void Main(string[] args)
        {
        }

        private static void ReverseBlocks<T>(T[] arr, int blocksize)
        {
            for (var k = 0; k + blocksize <= arr.Length; k += blocksize)
                Reverse(arr, k, blocksize);
        }

        private static void Reverse<T>(T[] arr, int start, int count)
        {
            for (int i = start, j = start + count - 1; i < j; i++, j--)
                Swap(ref arr[i], ref arr[j]);
        }
        private static void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
    }
}
