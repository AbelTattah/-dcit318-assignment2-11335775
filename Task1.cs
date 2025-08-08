using System;

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

class Program
{
    static void Main(string[] args)
    {
        // Create instances
        Task1 genericAnimal = new Task1();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Call MakeSound on each
        genericAnimal.MakeSound(); // Output: Some generic sound
        dog.MakeSound();           // Output: Bark
        cat.MakeSound();           // Output: Meow

        Console.ReadLine();
    }
}
