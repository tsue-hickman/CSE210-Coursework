public class Rectangle : Shapes
{
    private float len; // length of rect
    private float wid; // width of rect


    public Rectangle(string col, float length, float width) : base(col)
    {
        len = length;
        wid = width;
    }
}