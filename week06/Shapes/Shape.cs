using System.Diagnostics.Contracts;

public abstract class Shape
{
    private string color; // store the color of the shape

    public Shape(string shapeColor)
    {
        color = shapeColor;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string newColor)
    {
        color = newColor;
    }

    // Virtual method to be overriden by derived classes
    public abstract float GetArea();
}