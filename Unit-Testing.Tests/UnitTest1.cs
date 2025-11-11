using NUnit.Framework;
using Tut2_s30472;

namespace Tut2_s30472_Tests
{
    public class Tests
    {
        private readonly IShape sphere = new Sphere(5);
        private readonly IShape cube = new Cube(5);
        private readonly IShape cylinder = new Cylinder(6, 9);
        private readonly IShape rectangle = new Rectangle(4, 8);

        
        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }
        
        [Test]
        public void TestCubeCalculateArea()
        {
            Assert.That(cube.CalculateArea(), Is.EqualTo(150).Within(0.001));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            Assert.That(cube.CalculateVolume(), Is.EqualTo(125).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateArea()
        {
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(565.487).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(1017.876).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateArea()
        {
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(32).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateVolume()
        {
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0).Within(0.001));
        }
    }
}
