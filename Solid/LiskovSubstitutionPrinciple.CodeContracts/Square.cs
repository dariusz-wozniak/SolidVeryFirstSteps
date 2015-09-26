using System;
using System.Diagnostics.Contracts;

namespace Solid.LiskovSubstitutionPrinciple.CodeContracts
{
    public class Square : Rectangle
    {
        public override void SetSize(double width, double height)
        {
            Contract.Requires<ArgumentException>(width == height);

            base.SetSize(width, height);
        }
    }
}