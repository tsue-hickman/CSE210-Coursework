using System;

class Program
{
    static void Main(string[] args)
    {
        // Test constructor 1: Default fraction (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); // Output: 1/1
        Console.WriteLine(f1.GetDecimalValue());   // Output: 1

        // Test constructor 2: Whole number (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString()); // Output: 5/1
        Console.WriteLine(f2.GetDecimalValue());   // Output: 5

        // Test constructor 3: Fraction (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString()); // Output: 3/4
        Console.WriteLine(f3.GetDecimalValue());   // Output: 0.75

        // Test constructor 3: Fraction (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString()); // Output: 1/3
        Console.WriteLine(f4.GetDecimalValue());   // Output: 0.3333333333333333

        // Test getters and setters
        Fraction f5 = new Fraction();
        f5.SetTop(7);
        f5.SetBottom(8);
        Console.WriteLine($"After setting: {f5.GetTop()}/{f5.GetBottom()}"); // Output: After setting: 7/8
    }
}