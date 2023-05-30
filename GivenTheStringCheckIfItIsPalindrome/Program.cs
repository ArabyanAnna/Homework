using System;
class Program
{
    static void Main()

    {

        Console.WriteLine("Please, enter a word:");
        string word = Console.ReadLine();

        char [] charword = word.ToCharArray();
        Array.Reverse(charword);

        string reverseword = new string(charword); 

        if (word == reverseword) {
            Console.Write("It is palindrom word");
        }
        else Console.Write ("It isn`t a palindrom word");

       

        Console.ReadKey();
    }
}

