namespace Solid.LiskovSubstitutionPrinciple.Refactored.Design
{
    public interface IShape
    {
        
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Square : IShape
    {
        public double Width { get; set; }
    }
}
