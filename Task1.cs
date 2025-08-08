
class Task1
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Task1
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Task1
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

