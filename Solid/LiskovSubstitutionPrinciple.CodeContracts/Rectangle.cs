using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Solid.LiskovSubstitutionPrinciple.CodeContracts
{
    public class Rectangle
    {
        protected double Width { get; private set; }
        protected double Height { get; private set; }

        public virtual void SetSize(double width, double height)
        {
            Contract.Requires<ArgumentException>(width > 0);
            Contract.Requires<ArgumentException>(height > 0);

            Width = width;
            Height = height;
        }

        private void Init()
        {
            SetSize(-1d, -2d);
        }
    }
}