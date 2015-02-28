using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Morse_code_translator
{
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read or write ?");
            var choice = Console.ReadLine().ToLower();

            if (choice == "read")
            {
                var input = Console.ReadLine();
                ConvertFromMorse(input);
            }
            else
            {
                var input = Console.ReadLine().ToUpper();
                ConvertToMorse(input);
            }

            Console.ReadKey();

        }

        private static void ConvertToMorse(string input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write('/');
                }
                var c = input[i];
                if (MorseDictionary.ContainsKey(c))
                {
                    Console.Write(MorseDictionary[c]);
                }
            }
        }

        private static void ConvertFromMorse(string input)
        {



            string[] morse = Regex.Split(input, " /");
            foreach (var Item in morse)
            {
                var tmp = MorseDictionary.First(x => x.Value == Item).Key;
                Console.Write(tmp);

            }
        }


        private static readonly Dictionary<char, string> MorseDictionary = new Dictionary<char, string>()
            {
                {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
                {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
            };

    }
}
