public abstract class Shapes
{
    private string _color; //color of the shape

    public Shapes(string shape_color)
    {
        _color = shape_color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string new_color)
    {
        _color = new_color;
    }

    public abstract float GetArea(); // abstract method for getting the area
}