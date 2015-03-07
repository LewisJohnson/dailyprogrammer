/*
We could use 
===========================================================
Enumerable.Repeat('@', treeHeight).ToArray()
===========================================================
But this way is just as fast
*/

namespace _17___TreeMaker
{
    using System;

    static class Program
    {
        static void Main(string[] args)
        {
            PrintTree(6);
        }

        static void PrintTree(int treeHeight)
        {
            var tree = "";
            for (var i = 0; i < treeHeight; i++)
            {
                tree += "@@";
                Console.WriteLine(tree);
            }
        }
    }
}
