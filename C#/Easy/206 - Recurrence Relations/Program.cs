using System;
using System.Collections.Generic;

namespace RecurrenceRelations
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Expression");
            var ex = Console.ReadLine();

            Console.WriteLine("First Term");
            var f = int.Parse(Console.ReadLine());

            Console.WriteLine("How many terms do you want?");
            var n = int.Parse(Console.ReadLine());

            var terms = new int[n];
            terms[0] = f;

            Console.WriteLine("Term 0: {0}", terms[0]);

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    terms[i] = Calc(ex, terms[i]);
                    Console.WriteLine("Term {0}: {1}", i + 1, terms[i]);
                }
                else
                {
                    terms[i] = Calc(ex, terms[i - 1]);
                    Console.WriteLine("Term {0}: {1}", i + 1, terms[i]);
                }
            }

            Console.ReadLine();
        }

        private static int Calc(string expression, int number)
        {
            var operators = new Dictionary<char, Func<int, int, int>>()
                                {
                                    { '+', (a, b) => a + b },
                                    { '-', (a, b) => a - b },
                                    { '/', (a, b) => a / b },
                                    { '*', (a, b) => a * b },
                                };

            if (expression.Contains(" "))
            {
                string[] split = expression.Split();
                foreach (var item in split)
                {
                    var op = item[0];
                    var amt = int.Parse(item.Substring(1));
                    number = operators[op](number, amt);

                }

                return number;

            }

            var op2 = expression[0];
            var amt2 = int.Parse(expression.Substring(1));
            number = operators[op2](number, amt2);
            return number;
        }
    }
}
