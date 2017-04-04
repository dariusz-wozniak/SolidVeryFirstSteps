using Solid.DependencyInversionPrinciple.Refactored;
using Solid.InterfaceSegregationPrinciple;
using Solid.OpenClosedPrinciple;
using Solid.OpenClosedPrinciple.Refactored;

namespace CodeMetrics
{
    class SomeUnnamedClass
    {
        void DoSth()
        {
            // That's a non-sense piece of code for code metrics calculations:
            int x = 33;
            string z = "";

            for (int i = 0; i < x; ++i)
            {
                z += i;
            }

            var asdf = (string)z.Clone();
            asdf += "asdf";

            CircleDrawer drawer;
            IShapeDrawer drawer0;
            ShapeDrawingUtility<CircleDrawer> shapeDrawingUtility;
            RectangleDrawer rectangleDrawer;
            Circle circle;
            CopyService copyService = new CopyService();
            IReader reader;
            IWriter writer;
            new Solid.DependencyInversionPrinciple.CopyService().Copy();
            IAnimal animal;
        }
    }
}
