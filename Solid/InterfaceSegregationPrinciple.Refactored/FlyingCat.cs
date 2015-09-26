using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.InterfaceSegregationPrinciple.Refactored
{
    class FlyingCat : Cat, IFlyable, IRunnable { public void Fly() { } }
}
