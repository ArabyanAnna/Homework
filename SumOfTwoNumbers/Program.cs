using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int sum;
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sum = num1 + num2);
            Console.ReadKey();
        }
    }
}
