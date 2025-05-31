public class Square : Shapes
{
    private float _sideLength = side; // store side length

    public Square(string color, float side) : base(color)
    {
        _sideLength = side; // set side
    }


}