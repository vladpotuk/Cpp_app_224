using System;

class Program
{
    static void Main(string[] args)
    {
        Tiger tiger = new Tiger("Siberian Tiger", 5, "Forest");
        Crocodile crocodile = new Crocodile("Nile Crocodile", 10, "River");
        Kangaroo kangaroo = new Kangaroo("Red Kangaroo", 3, "Outback");

        Console.WriteLine("Tiger Information:");
        tiger.DisplayInfo();
        tiger.Hunt();

        Console.WriteLine();

        Console.WriteLine("Crocodile Information:");
        crocodile.DisplayInfo();
        crocodile.Hunt();

        Console.WriteLine();

        Console.WriteLine("Kangaroo Information:");
        kangaroo.DisplayInfo();
        kangaroo.Graze();
    }
}
