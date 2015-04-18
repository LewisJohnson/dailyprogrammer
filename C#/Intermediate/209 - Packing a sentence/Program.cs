using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _209___Packing_a_sentence
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new SentenceBox(Console.ReadLine()));

            Console.ReadKey();
        }
    }

    public class SentenceBox
    {
        private static readonly Random Rand = new Random();

        private readonly string mSentence;

        private readonly Tuple<int, int> mBoxDims;
        private readonly char[,] mBox;

        private Tuple<int, int> mPackStart;

        public SentenceBox(string sentence)
        {
            this.mSentence = sentence.Replace(" ", "").ToUpper();

            this.mBoxDims = this.CalculateBoxDimensions(this.mSentence);
            this.mBox = new char[this.mBoxDims.Item1, this.mBoxDims.Item2];

            Pack();
        }

        private void Pack()
        {
            this.mBox.Initialize();
            this.mPackStart = new Tuple<int, int>(Rand.Next(this.mBoxDims.Item1), Rand.Next(this.mBoxDims.Item2));

            if (!this.Traverse(this.mPackStart.Item1, this.mPackStart.Item2, new Stack<char>(this.mSentence.Reverse())))
                throw new ApplicationException("Unable to find a valid sentance pack at random start location.");
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine(string.Format("{0} {1}", this.mPackStart.Item1 + 1, this.mPackStart.Item2 + 1));

            for (var y = 0; y < this.mBoxDims.Item2; y++)
            {
                var chars = new char[this.mBoxDims.Item1];

                for (var x = 0; x < this.mBoxDims.Item1; x++)
                {
                    chars[x] = this.mBox[x, y];
                }

                str.AppendLine(string.Join("    ", chars));
            }

            return str.ToString();
        }

        private bool Traverse(int x, int y, Stack<char> sentenceStack)
        {
            this.mBox[x, y] = sentenceStack.Pop();

            if (sentenceStack.Count > 0)
            {
                var validDirectionList = new List<Tuple<int, int>>();

                // can we go left?
                if (x > 0 && this.mBox[x - 1, y] == '\0')
                    validDirectionList.Add(new Tuple<int, int>(x - 1, y));

                // can we go right?
                if (x < this.mBoxDims.Item1 - 1 && this.mBox[x + 1, y] == '\0')
                    validDirectionList.Add(new Tuple<int, int>(x + 1, y));

                // can we go up?
                if (y > 0 && this.mBox[x, y - 1] == '\0')
                    validDirectionList.Add(new Tuple<int, int>(x, y - 1));

                // can we go down?
                if (y < this.mBoxDims.Item2 - 1 && this.mBox[x, y + 1] == '\0')
                    validDirectionList.Add(new Tuple<int, int>(x, y + 1));

                while (validDirectionList.Count > 0)
                {
                    var i = Rand.Next(validDirectionList.Count);
                    var d = validDirectionList[i];

                    if (this.Traverse(d.Item1, d.Item2, sentenceStack))
                        return true;
                    else
                        validDirectionList.RemoveAt(i);
                }

                // if we get here we hit a dead end and need to back out
                sentenceStack.Push(this.mBox[x, y]);
                this.mBox[x, y] = '\0';
                return false;
            }
            else
                return true;
        }

        private Tuple<int, int> CalculateBoxDimensions(string sentence)
        {
            var l = sentence.Length;

            var w = 1;
            var h = l;

            for (var i = 1; l / i >= i; i++)
            {
                if ((double)l / (double)i == (l / i))
                {
                    w = i;
                    h = l / i;
                }
            }

            return new Tuple<int, int>(w, h);
        }
    }
}
