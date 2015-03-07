namespace _20___Prime_me_baby
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Primes below 2000");
            for (var i = 0; i < 2000; i++)
            {
                var prime = CheckPrime(i);
                if (prime)
                {
                    Console.WriteLine("Prime: {0}", i);
                }
            }

            Console.ReadLine();
        }

        private static bool CheckPrime(int primeyness)
        {
            if ((primeyness & 1) == 0)
            {
                if (primeyness == 2)
                {
                    return true;
                }
                return false;
            }
            for (var i = 3; (i * i) <= primeyness; i += 2)
            {
                if ((primeyness % i) == 0)
                {
                    return false;
                }
            }
            return primeyness != 1;
        }
    }
}


        