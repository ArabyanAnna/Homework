using System;

class Program
{
    static void Main()
    {
        string planet;

        Console.WriteLine("Enter a planet name:");
        planet = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(planet))
        {
            Console.WriteLine("You did not enter a planet name.");
        }
        else
        {
            if (planet == "Mercury")
            {
                Console.WriteLine("The distance from the sun is 57,900,000km, the color is slate gray");
            }
            else if (planet == "Venus")
            {
                Console.WriteLine("The distance from the sun is 108,200,000km, the color is pearly white");
            }
            else if (planet == "Earth")
            {
                Console.WriteLine("The distance from the sun is 149,600,000km, the color is vibrant blue");
            }
            else if (planet == "Mars")
            {
                Console.WriteLine("The distance from the sun is 227,900,000km, the color is dusky red");
            }
            else if (planet == "Jupiter")
            {
                Console.WriteLine("The distance from the sun is 778,600,000km, the color is beige with brilliant red-brown belts");
            }
            else if (planet == "Saturn")
            {
                Console.WriteLine("The distance from the sun is 778,600,000km, the color is beige with brilliant red-brown belts");
            }
            else if (planet == "Uranus")
            {
                Console.WriteLine("The distance from the sun is 2,872,500,000km, the color is opaque blue");
            }
            else if (planet == "Neptune")
            {
                Console.WriteLine("The distance from the sun is 4,495,100,000km, the color is opaque blue");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
