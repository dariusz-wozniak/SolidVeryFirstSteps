using NUnit.Framework;

namespace Solid.LiskovSubstitutionPrinciple.Tests
{
    [TestFixture(typeof(Rectangle))]
    [TestFixture(typeof(Square))]
    public class Tests<T> where T : Rectangle, new()
    {
        private Rectangle _rectangle;

        [SetUp]
        public void Setup()
        {
            _rectangle = new T();
        }

        [Test]
        public void Invariant()
        {
            _rectangle.Height = 30;
            _rectangle.Width = 40;

            Assert.AreEqual(30, _rectangle.Height);
            Assert.AreEqual(40, _rectangle.Width);
        }
    }
}
