using NUnit.Framework;

namespace Solid.LiskovSubstitutionPrinciple.Tests
{
    [TestFixture(typeof(Rectangle))]
    [TestFixture(typeof(Square))]
    public class Tests<T> where T : Rectangle, new()
    {
        [Test]
        public void Invariant()
        {
            var rectangle = new T
            {
                Height = 30,
                Width = 40
            };

            Assert.That(rectangle.Height, Is.EqualTo(30));
            Assert.That(rectangle.Width, Is.EqualTo(40));
        }
    }
}