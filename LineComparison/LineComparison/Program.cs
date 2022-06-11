using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
            Console.WriteLine("Enter value for x1");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for x2");
            int x2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for y1");
            int y1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for y2");
            int y2 = Int32.Parse(Console.ReadLine());
            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            int z = x + y;
            double length = Math.Sqrt(z);
            Console.WriteLine("Length of the line is" + length);

        }
    }
}
