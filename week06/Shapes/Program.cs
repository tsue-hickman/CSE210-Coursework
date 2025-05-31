using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // need to create a list for shapes 
        List<Shapes> shapeList = new List<Shapes>();

        // here are the shapes from the other cs files
        shapeList.Add(new Square("red", 5));
        shapeList.Add(new Rectangle("blue", 4, 6));
        shapeList.Add(new Circle("green", 3));


        // loops the list and print info out
        foreach (Shapes s in shapeList)
        {
            Console.WriteLine($"Color: {s.GetColor()}, Area: {s.GetArea()}");
        }
    }
}

