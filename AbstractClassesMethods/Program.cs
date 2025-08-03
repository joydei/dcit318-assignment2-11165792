using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating Abstract Classes and Methods");

        Circle myCircle = new Circle(5.0);
        Console.WriteLine($"Area of the circle with radius 5: {myCircle.GetArea():F2}");

        Rectangle myRectangle = new Rectangle(4.0, 6.0);
        Console.WriteLine($"Area of the rectangle with sides 4 and 6: {myRectangle.GetArea():F2}");
    }
}