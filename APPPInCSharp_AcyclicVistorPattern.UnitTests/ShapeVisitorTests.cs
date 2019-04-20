using NUnit.Framework;
using System.Collections.Generic;

namespace APPPInCSharp_AcyclicVistorPattern.UnitTests
{
    [TestFixture]
    public class ShapeVisitorTests
    {
        private PriorityConfigurator p;
        private Circle c1;
        private Circle c2;
        private Square s1;
        private Square s2;
        private Square s3;

        [SetUp]
        public void SetUp()
        {
            p = new PriorityConfigurator();
            c1 = new Circle();
            c2 = new Circle();
            s1 = new Square();
            s2 = new Square();
            s3 = new Square();
        }

        [Test]
        public void CirclePriority()
        {
            c1.Accept(p);
            Assert.AreEqual(c1.Priotity, 1);
        }

        [Test]
        public void SquarePriority()
        {
            s1.Accept(p);
            Assert.AreEqual(s1.Priotity, 2);
        }

        [Test]
        public void SortByPriority()
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(s1);
            shapes.Add(c2);
            shapes.Add(s3);
            shapes.Add(s2);
            shapes.Add(c1);

            foreach (var shape in shapes)
            {
                shape.Accept(p);
            }

            shapes.Sort();

            Assert.IsTrue(shapes[0] is Circle);
            Assert.IsTrue(shapes[1] is Circle);
            Assert.IsTrue(shapes[2] is Square);
            Assert.IsTrue(shapes[3] is Square);
            Assert.IsTrue(shapes[4] is Square);
        }
    }
}