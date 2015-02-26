using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{

    class Program
    {
        static void Main(string[] args)
        {
            var cipher = new Cipher();
            var txt = Console.ReadLine();

            var result = cipher.Encrypt(txt);
            var result2 = cipher.EncryptWithEncoder(txt);

            Console.WriteLine(result);
            Console.WriteLine("/n------------------------------------------");
            Console.WriteLine(result2);

            Console.Read();

        }
    }
}
