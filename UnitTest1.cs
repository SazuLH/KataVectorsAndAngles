using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorsAndAngle;

namespace UnitTestProjectVectors
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Magnitude()
        {
            Vector obj = new Vector(4, 6);
            Assert.AreEqual(7.211102550927978, obj.Magnitude());
        }
        [TestMethod]
        public void DotProduct()
        {
            Vector obj = new Vector(6, 8);
            Vector obj2 = new Vector(4, 6);
            Assert.AreEqual(72, obj.DotProduct(obj, obj2));
        }
        [TestMethod]
        public void AngleBetween()
        {
            Vector obj = new Vector(6, 8);
            Vector obj2 = new Vector(4, 6);
            Assert.AreEqual(3.181442975869048, obj.AngleBetween(obj, obj2));
        }
    }
}
