using System;
using System.Xml.Linq;

public class Kangaroo : Animal, IHerbivore
{
    public Kangaroo(string name, int age, string habitat) : base(name, "Kangaroo", age, habitat)
    {
    }

    public void Graze()
    {
        Console.WriteLine($"{Name} is grazing.");
    }
}

public interface IHerbivore
{
    void Graze();
}
