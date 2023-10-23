using System;
using System.Linq;
class Program


{
    static void Main()
    {
        int[] myArray = { 3, 6, -2, -5, 7, 3 };
        int MaxValue  = myArray[0];

        for (int i = 1; i < myArray.Length; i++) {
            
              if (myArray[i] > MaxValue) 
            { 
                MaxValue = myArray[i];
            }
       
        }
       

        Console.WriteLine(MaxValue);
        Console.ReadLine();
    }

}
