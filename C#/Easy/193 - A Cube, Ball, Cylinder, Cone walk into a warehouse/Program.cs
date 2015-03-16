namespace Warehouse
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            //Either functions or write it out on the fly. I like functions.ph

            Console.WriteLine("Input volume in cubic meters. Without the m though. please.");
            var input = double.Parse(Console.ReadLine());
            if (input <= 0)
            {
                Console.Clear();
                Console.WriteLine("Try again. Input a number like 27 or somrthing");
                input = double.Parse(Console.ReadLine());
            }

            while (true)
            {
                Console.WriteLine("Which shape ? all is avalible");
                var s = Console.ReadLine().ToLower();

                switch (s)
                {
                    case "cube":
                        CubeVolume(input);
                        break;

                    case "sphere":
                        SphereVolume(input);
                        break;

                    case "cylinder":
                        CylinderVolume(input);
                        break;

                    case "cone":
                        ConeVolume(input);
                        break;
                    default:
                        CubeVolume(input);
                        SphereVolume(input);
                        CylinderVolume(input);
                        ConeVolume(input);
                        break;
                }
            }
        }



        //All formulas from Wikipedia, and my maths knowledge.
        //String format instaed of rounding because you cant round doubles to a range :(

        private static void CubeVolume(double volume)
        {
            var r = Math.Pow(volume, (1.0 / 3.0));
            Console.WriteLine("Cube: {0}m width, {0}m high, {0}m tall", string.Format("{0:0.00}", r));
        }

        private static void SphereVolume(double volume)
        {
            var r = Math.Pow(((volume * 0.75) / Math.PI), (1.0 / 3.0));
            Console.WriteLine("Sphere: {0}m radius", string.Format("{0:0.00}", r));
        }

        private static void CylinderVolume(double volume)
        {
            var h = Math.Pow((4 * volume) / Math.PI, (1.0 / 3.0));
            var r = 0.5 * h;
            Console.WriteLine(
                "Cylinder: {0}m tall, diameter of {1}m",
                string.Format("{0:0.00}", h),
                string.Format("{0:0.00}", (2 * r)));
        }

        private static void ConeVolume(double volume)
        {
            var h = Math.Pow((12 * volume) / Math.PI, (1.0 / 3.0));
            var r = 0.5 * h;
            Console.WriteLine(
                "Cone: {0}m tall, {1}m radius",
                string.Format("{0:0.00}", h),
                string.Format("{0:0.00}", r));
        }
    }
}