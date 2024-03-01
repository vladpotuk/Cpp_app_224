using System;
using System.Xml.Linq;

public class Crocodile : Animal, IPredator
{
    public Crocodile(string name, int age, string habitat) : base(name, "Crocodile", age, habitat)
    {
    }

    public void Hunt()
    {
        Console.WriteLine($"{Name} is hunting.");
    }
}
