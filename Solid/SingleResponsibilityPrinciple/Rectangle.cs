using System;

namespace Solid.SingleResponsibilityPrinciple
{
    public class Rectangle
    {
        public double GetArea() { throw new NotImplementedException();}
        public double GetPerimeter() { throw new NotImplementedException(); }
        public void Draw() {  }
        public string SerializeToXml() { throw new NotImplementedException();}
    }
}