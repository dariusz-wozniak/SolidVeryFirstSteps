using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.SingleResponsibilityPrinciple
{
    public class Lcom
    {
        public class NestedClass
        {
            public int x;
        }
#pragma warning disable
        public int X;
        public int Y;
        private int _x;
        private int _y;
        public int a0;
        public int a1;
        public int a2;
        public int[] aInts;
        public int a3;
        public int a4;
        public int a5;
        public int a6;
        public int a7;
        public int a8;
        public int a9;
        public int a10;
        public void SomeMethod1() {}
#pragma warning disable
        public int SomeMethod2()
        {
            return _x + _y + X + Y*2;
        }

        public int SomeMethod3()
        {
            return SomeMethod2() + new NestedClass().x + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10;
        }
    }
}
