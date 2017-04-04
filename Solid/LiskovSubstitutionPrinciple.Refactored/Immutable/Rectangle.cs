namespace Solid.LiskovSubstitutionPrinciple.Refactored.Immutable
{
    public class Rectangle
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; }
        public double Height { get; }
    }

    public class Square : Rectangle
    {
        public Square(double width) : base(width, width) { }
    }
}
