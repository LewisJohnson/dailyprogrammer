    using System;
    
    namespace _210___Loppy_robots
    {
        class Program
        {
            static void Main()
            {
                var collect = "";
    
                Console.WriteLine("How many do you want to test ?");
                var n = int.Parse(Console.ReadLine());
    
                for (var i = 0; i < n; i++)
                {
                    Console.Clear();
                    Console.Write("Input:");
                    var input = Console.ReadLine();
                    collect += "Loop " + n + ": " + LoopeyLoops(input) + "\n";
                }
                Console.Clear();
                Console.WriteLine(collect);
    
                Console.ReadLine();
    
    
            }
    
            static string LoopeyLoops(string input)
            {
                var array = input.ToUpper().ToCharArray();
    
                int xdir = 0,
                    ydir = 0,
                    direction = 0;
    
                foreach (var item in array)
                {
    
                    switch (item)
                    {
                        case 'R':
                            if (++direction == 4) direction = 0;
                            break;
                        case 'L':
                            if (--direction == -1) direction = 3;
                            break;
                        case 'S':
                            switch (direction)
                            {
                                case 0:
                                    ydir++;
                                    break;
                                case 1:
                                    xdir++;
                                    break;
                                case 2:
                                    ydir--;
                                    break;
                                case 3:
                                    xdir--;
                                    break;
                            }
                            break;
                    }
                }
    
                if (xdir == 0 && ydir == 0 && direction == 0)
                {
                    return "Loop detected! 1 cycle to complete loop";
                }
    
                switch (direction)
                {
                    case 1:
                    case 3:
                        return "Loop detected! 4 cycle(s) to complete loop";
                    case 2:
                        return "Loop detected! 2 cycle(s) to complete loop";
                    default:
                        return "No loop.";
                }
            }
        }
    }
    