using NUnit.Framework;
using ShapeArear;
using NUnit;
namespace ShapeArearTests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void CorrectAreaCircleCount()
        {
            var circle1 = new Circle(10);
            Assert.AreEqual(314.16, Math.Round(circle1.Area, 2));

            var circle2 = new Circle(11);
            Assert.AreEqual(380.13,Math.Round(circle2.Area, 2));
        }

        [Test]
        public void CorrectAreaCircleCountAfterSetting()
        {
            var circle1 = new Circle(10);
            Assert.AreEqual(314.16, Math.Round(circle1.Area, 2));
            
            circle1.SetRadiusLength(11);
            Assert.AreEqual(380.13, Math.Round(circle1.Area, 2));
        }

        [Test]
        public void ExceptionHandlingAfterCircleSetting()
        {
            var circle1 = new Circle(10);
            Assert.Catch(()=>circle1.SetRadiusLength(-1));
        }

        [Test]
        public void CorrectAreaCountOnTrigon()
        {
            var trigon1 = new Trigon(2, 3, 4);
            Assert.AreEqual(2.90, Math.Round(trigon1.Area, 2));
        }
        
        [Test]
        public void CorrectAreaCountOnRegularTrigon()
        {
            var trigon1 = new RegularTrigon(5);
            Assert.AreEqual(10.83, Math.Round(trigon1.Area, 2));
        }
        
        [Test]
        public void CorrectAreaCountOnRegularShape()
        {
            var shape = new RegularShape(6, 7);
            Assert.AreEqual(130.82, Math.Round(shape.Area, 2));
        }

        [Test]
        public void CorrectDetectOfRegularTrigon()
        {
            var trigon = new Trigon(2, 3, 5);
            var trigon1 = new Trigon(2, 2, 2);
            Assert.AreEqual(false, trigon.IsRegularTrigon);
            Assert.AreEqual(true, trigon1.IsRegularTrigon);
        }
    }
}