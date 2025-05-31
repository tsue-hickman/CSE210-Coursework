public class Circle : Shape
{
    private float rad; // circle radius

    public Circle(string color, float radius) : base(color)
    {
        rad = radius; // set the radius
    }

    public override float GetArea()
    {
        return (float)(Math.PI * Math.Pow(rad, 2)); // calculate circle area
    }
}