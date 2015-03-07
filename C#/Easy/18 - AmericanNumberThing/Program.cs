using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___AmericanNumberThing
{

    /*
    Numbers from some Nokia phone

    1 - NULL
    2 - ABC
    3 - DEF
    4 - GHI
    5 - JKL
    6 - MNO
    7 - PQRS
    8 - TUV
    9 - WXYZ    
    
    See here for similiar refrence - "http://en.wikipedia.org/wiki/Telephone_keypad#mediaviewer/File:Telephone-keypad2.svg"
    Sample number - "1-800-COMCAST"

    */



    static class Program
    {
        private static readonly Dictionary<int, char> CharDictionary = new Dictionary<int, char> {
             {2, 'a'},
             {2, 'b'},
             {2, 'c'},
            //=========
             {3, 'd'},
             {3, 'e'},
             {3, 'f'},
            //=========
             {4, 'g'},
             {4, 'h'},
             {4, 'i'},
            //=========
             {5, 'j'},
             {5, 'k'},
             {5, 'l'},
            //=========
             {6, 'm'},
             {6, 'n'},
             {6, 'o'},
            //=========
             {7, 'p'},
             {7, 'q'},
             {7, 'r'},
             {7, 's'},
            //=========
             {8, 't'},
             {8, 'u'},
             {8, 'v'},
            //=========
            {9, 'w'},
             {9, 'x'},
             {9, 'y'},
             {9, 'z'},
            //=========

        };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter some number and letter thing");
            var num = Console.ReadLine();
            ChangeText(num);

            Console.ReadLine();



        }

        private static string ChangeText(string nunmber)
        {
            var tmp = 0;

            foreach (var item in nunmber)
            {

                tmp = CharDictionary.First(x => x.Value == item).Key;
            }

            return tmp.ToString();

        }
    }
}
