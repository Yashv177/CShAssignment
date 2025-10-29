public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void Speak();
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine($"{Name} barks.");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine($"{Name} meows.");
    }
}
