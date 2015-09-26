using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.InterfaceSegregationPrinciple.Refactored
{
    public interface IFlyable { void Fly(); }
    public interface IBarkable { void Bark(); }
    public interface IRunnable { void Run(); }

    public class Dog : IRunnable, IBarkable { public void Run() { } public void Bark() { } }
    public class Cat : IRunnable { public void Run() { } }
    public class Bird : IRunnable, IFlyable { public void Run() { } public void Fly() { } }
}

