// See https://aka.ms/new-console-template for more information
Console.WriteLine();

public abstract class Base
{
    Fish whaleFish = new Fish();

    public string name = "Whale";
}

class Fish : Base
{
    public string newName = "New Whale";
}