using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrows_and_Arrow
{
    using System.IO;

    internal class Program
    {

        private static void Main(string[] args)
        {

            char[] dirs = { '^', 'v', '>', '<' };

            Console.Title = "Arrows and Arrows";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Reading input from input.txt");

            if (!File.Exists("input.txt"))
            {
                Console.WriteLine("input.txt doesn't exist.");
                Console.ReadKey();
                return;
            }

            string[] input = File.ReadAllLines("input.txt");
            var heigth = input.Length;
            var width = input[0].Length;

            char[] parsedInput = new char[heigth * width];

            for (int i = 0; i < heigth * width; i++) parsedInput[i] = input[IndexToPos(i, width)[1]][IndexToPos(i, width)[0]];

            var loops = new List<List<int>>();
            var inLoop = new List<int>();

            for (int startIndex = 0; startIndex < parsedInput.Length; startIndex++)
            {
                List<int> closed = new List<int>();
                int currentIndex = startIndex;

                while (!closed.Contains(currentIndex))
                {
                    if (inLoop.Contains(currentIndex)) break;

                    closed.Add(currentIndex);
                    inLoop.Add(currentIndex);
                    int[] pos = IndexToPos(currentIndex, width);

                    if (parsedInput[currentIndex] == dirs[0]) // Up
                        pos[1]--;
                    else if (parsedInput[currentIndex] == dirs[1]) // Down
                        pos[1]++;
                    else if (parsedInput[currentIndex] == dirs[2]) // Right
                        pos[0]++;
                    else if (parsedInput[currentIndex] == dirs[3]) // Left
                        pos[0]--;

                    if (pos[0] < 0) pos[0] = width - 1;
                    else if (pos[0] > width - 1) pos[0] = 0;

                    if (pos[1] < 0) pos[1] = heigth - 1;
                    else if (pos[1] > heigth - 1) pos[1] = 0;

                    currentIndex = PosToIndex(pos[0], pos[1], width);
                }

                if (closed.Contains(currentIndex)) loops.Add(FindLoop(closed, currentIndex));
            }

            int biggest = 0;

            for (int i = 1; i < loops.Count; i++) if (loops[i].Count > loops[biggest].Count) biggest = i;

            Console.WriteLine("\nFound loop! Size: {0}\n", loops[biggest].Count);
            DrawLoop(parsedInput, width, loops[biggest]);
            Console.ReadKey();

        }

        private static void DrawLoop(char[] parsedInput, int w, List<int> loop)
        {
            for (var i = 0; i < parsedInput.Length; i++)
            {
                if (loop.Contains(i)) Console.ForegroundColor = ConsoleColor.Red;

                Console.Write(parsedInput[i]);

                if ((i + 1) % w == 0 && i != 0) Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static List<int> FindLoop(List<int> closed, int toStart)
        {
            var result = new List<int>();

            for (int i = closed.FindIndex(x => x == toStart); i < closed.Count; i++) result.Add(closed[i]);

            return result;
        }

        private static int PosToIndex(int x, int y, int w)
        {
            return (y * w) + x;
        }

        private static int[] IndexToPos(int i, int w)
        {
            return new int[] { i % w, (i - (i % w)) / w };
        }
    }
}
