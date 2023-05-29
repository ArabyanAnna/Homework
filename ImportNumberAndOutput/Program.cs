
using System;
class Program
{
    static void Main()

    {
        

        Console.WriteLine("Enter a number:");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());

        
        while (n > 0)
        {
            n--;
            Console.Write(k);

        }


       
        Console.ReadKey();
    }
}