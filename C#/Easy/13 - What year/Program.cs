namespace _13___What_year
{
    using System;

    static class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter DD/MM ");
        var r = Console.ReadLine();
        string[] a = r.Split('/');
        Console.WriteLine(YearCalc(int.Parse(a[0]), int.Parse(a[1])));
        Console.ReadKey();
    }      

    static int YearCalc(int day, int month)
    {
        var months = new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        var i = month - 1;
        var j = 0;
        while(i > 0)
        {
            j += months[i];
            --i;
        }
        return j + day;
    }
    }
}
