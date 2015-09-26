namespace Solid.LiskovSubstitutionPrinciple.Refactored.Immutable
{
    public class Rectangle
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double Width { get { return _width; } }
        public double Height { get { return _height; } }
    }

    public class Square : Rectangle
    {
        public Square(double width)
            : base(width, width)
        {
        }
    }
}
