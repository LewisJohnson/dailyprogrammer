using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PasswordProtected
{
    using System.Xml.Serialization;

    static class Program
    {

        const string Filepath = @"c:\password.txt";
        private static string password = "";

        static void Main(string[] args)
        {
            Console.WriteLine("This program is password protected.");

            if (!File.Exists(Filepath))
            {
                SetPassword();
            }

            Console.WriteLine("Please enter your password now: ");
            if (CheckPassword())
            {
                DummyProgram();
            }

        }

        static void SetPassword()
        {
            //The password will be sotred as plain text. Not good for real programs, but good enough for this.

            Console.WriteLine("You have not set a password yet. Please enter a password now: ");
            var pas = Console.ReadLine();

            if (!File.Exists(Filepath))
            {
                try
                {
                    using (var sw = File.CreateText(Filepath))
                    {
                        sw.Write(pas);
                    }

                }
                catch (IOException e)
                {
                    Console.WriteLine("We need write privileges");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Excpetion" + e.Message);
                    throw;
                }

                Console.WriteLine("Password set. The file has been made at: {0}", Filepath);
            }



        }

        static bool CheckPassword()
        {
            using (var sr = new StreamReader(Filepath))
            {
                password = sr.ReadToEnd();
            }

            var test = Console.ReadLine();

            if (test != password)
            {
                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine("Password incorrect. You have {0} more tries.", i);

                    test = Console.ReadLine();

                    if (test == password)
                    {
                        break;
                    }

                    if (i == 0)
                    {
                        Environment.Exit(0);

                    }
                }

            }

            Console.Clear();
            Console.WriteLine("Password correct.");

            return true;

        }

        static void DummyProgram()
        {
            Console.WriteLine("Welcome to your epic dummy program, Master.");
        }
    }
}
