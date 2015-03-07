namespace _12___Permutations
{
    using System;

    class Permute
    {
        public static void Swap(ref char a, ref char b)
        {
            if (a == b)
                return;
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public void Setper(char[] list)
        {
            var x = list.Length - 1;
            this.Go(list, 0, x);
        }

        public void Go(char[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                Console.Write(list);
                Console.WriteLine(" ");
            }
            else
                for (i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    this.Go(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }
    }
}