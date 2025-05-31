public class Square : Shapes
{
    private float _sideLength; // store side length

    public Square(string color, float side) : base(color)
    {
        _sideLength = side; // set side
    }

    public override float GetArea()
    {
        return _sideLength * _sideLength; // area is the square of the side
    }


}