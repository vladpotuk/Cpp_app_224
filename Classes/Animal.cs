using System;

public class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public string Habitat { get; set; }

    public Animal(string name, string species, int age, string habitat)
    {
        Name = name;
        Species = species;
        Age = age;
        Habitat = habitat;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Habitat: {Habitat}");
    }
}
