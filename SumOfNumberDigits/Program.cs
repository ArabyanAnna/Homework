using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        int digit;
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        while (num > 0)
        {
            digit = num % 10;
            sum = sum + digit;
            num = num / 10;
        }
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}