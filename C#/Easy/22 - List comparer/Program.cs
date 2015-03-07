using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___List_comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<string> { "a", "b", "c", "1", "4" };
            var list2 = new List<string> { "a", "x", "34", "4"};
            ListCompare(list1, list2);
            Console.ReadLine();
        }

        static void ListCompare<T>(ICollection<T> a, IEnumerable<T> b)
        {
            var appendedList = a.ToList();
            appendedList.AddRange(b.Where(t => !a.Contains(t)));
            foreach (var item in appendedList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
