namespace _210___intHarmony.com
{
    using System;

    class Program
    {
        private static void Main(string[] args)
        {
           var x = Convert(100);
           var y = Convert(42);

            var l = 0;
        }

        public static string Convert(int x)
        {
            char[] bits = new char[32];
            int i = 0;

            while (x != 0)
            {
                bits[i++] = (x & 1) == 1 ? '1' : '0';
                x >>= 1;
            }

            Array.Reverse(bits, 0, i);
            return new string(bits);
        }
    }
}
