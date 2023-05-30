
using System;
class Program
{
    static void Main()

    {

        Console.WriteLine("Enter a Year:");
        int year = Convert.ToInt32(Console.ReadLine());

        int century = (year - 1)/ 100 + 1;

        Console.Write(century);

        Console.ReadKey();
    }
}
