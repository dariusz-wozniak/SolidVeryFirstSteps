namespace Solid.OpenClosedPrinciple.Refactored
{
    public class ShapeDrawingUtility<T> where T : IShapeDrawer
    {
        public static void Draw(T t)
        {
            t.Draw();
        }
    }
}
