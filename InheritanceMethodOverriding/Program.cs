using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating Inheritance and Method Overriding");

        Animal myAnimal = new Animal();
        Console.Write("Animal sound: ");
        myAnimal.MakeSound();

        Dog myDog = new Dog();
        Console.Write("Dog sound: ");
        myDog.MakeSound();
        
        Cat myCat = new Cat();
        Console.Write("Cat sound: ");
        myCat.MakeSound();
    }
}