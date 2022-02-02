using System;
using ACloudTechie.Artifact.Calculate;

namespace SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine($"Sum of 5 and 6 is { Calculator.Add(5, 6) } ");
            Console.WriteLine($"5 * 6 is { Calculator.Multiply(5, 6) } ");
        }
    }
}
