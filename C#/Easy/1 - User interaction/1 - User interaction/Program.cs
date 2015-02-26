using System;

namespace User_interaction
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "";
            int age = 0;
            var username = "";

            Console.WriteLine("What is your name ?");
            name = Console.ReadLine();

            Console.WriteLine("What is your age ?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your Reddit Username ?");
            username = Console.ReadLine();

            Console.WriteLine("Your name is {0}, you are {1} years old, and your username is {2}", name, age, username);
        }

    }
}
