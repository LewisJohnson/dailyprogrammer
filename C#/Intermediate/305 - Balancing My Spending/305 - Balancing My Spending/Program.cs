using System;
using System.Collections.Generic;
using System.Linq;

class Program {

    public static List<int> debts;
    public static int amount;

    static void Main() {

        Console.Write("Enter number of transactions: ");
        amount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter transactions: ");
        try {
            debts = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToList();
        } catch (Exception) {
            Console.WriteLine("no");
            Environment.Exit(-1);
        }

        Console.Write("Result: ");
        for (int i = 0; i <= debts.Count - 1; i++) {
            if (i == 0) {
                if (debts.Take(1).Sum() == debts.Skip(1).Sum()) {
                    Console.Write(string.Format("0 "));
                }
            } else if (debts.Take(i).Sum() == debts.Skip(i + 1).Sum()) {
                Console.Write(string.Format("{0} ", i));
            }
        }
        Console.ReadKey();
        Environment.Exit(0);
    }
}