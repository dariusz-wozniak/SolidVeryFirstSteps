namespace Solid.OpenClosedPrinciple
{
    public class ShapeDrawingUtility
    {
        public void Draw(IShape shape)
        {
            if (shape is Rectangle) { DrawRectangle(); }
            else if (shape is Circle) { DrawCircle(); }
            // If we want to introduce new shape(s), 
            // we have to MODIFY this entity right HERE...
        }

        private void DrawRectangle() { }
        private void DrawCircle() { }
        // ...and HERE
    }
}
