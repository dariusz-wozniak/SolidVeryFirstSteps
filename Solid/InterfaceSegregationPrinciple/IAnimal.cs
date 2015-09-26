using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.InterfaceSegregationPrinciple
{
    public interface IAnimal
    {
        void Fly();
        void Run();
        void Bark();
    }

    public class Bird : IAnimal
    {
        public void Fly() { throw new NotImplementedException();  }
        public void Run() { throw new NotImplementedException(); }
        public void Bark() { throw new NotImplementedException(); }
    }

    public class Dog : IAnimal
    {
        public void Fly() { throw new NotImplementedException(); }
        public void Run() { throw new NotImplementedException(); }
        public void Bark() { throw new NotImplementedException(); }
    }

    public class Cat : IAnimal
    {
        public void Fly() { throw new NotImplementedException(); }
        public void Run() { throw new NotImplementedException(); }
        public void Bark() { throw new NotImplementedException(); }
    }
}
