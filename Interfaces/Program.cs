using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating Interfaces");

        IMovable myCar = new Car();
        IMovable myBicycle = new Bicycle();
        myCar.Move();
        myBicycle.Move();
        Console.WriteLine("Both Car and Bicycle implement the IMovable interface.");
        Console.WriteLine("\nUsing a collection of IMovable objects");
        IMovable[] movables = new IMovable[2];
        movables[0] = new Car();
        movables[1] = new Bicycle();

        foreach (IMovable movable in movables)
        {
            movable.Move();
        }
    }
}