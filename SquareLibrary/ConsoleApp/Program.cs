using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Triangle(new double[] { 3, 3, 3 });
            Console.WriteLine(triangle.Square());
        }
    }
}
