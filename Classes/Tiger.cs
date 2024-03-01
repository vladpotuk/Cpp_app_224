using System;
using System.Xml.Linq;

public class Tiger : Animal, IPredator
{
    public Tiger(string name, int age, string habitat) : base(name, "Tiger", age, habitat)
    {
    }

    public void Hunt()
    {
        Console.WriteLine($"{Name} is hunting.");
    }
}

public interface IPredator
{
    void Hunt();
}
