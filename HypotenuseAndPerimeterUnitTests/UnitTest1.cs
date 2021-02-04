using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HypotenuseAndPerimeterUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getHypotenuseTest()
        {
            double a = 2;
            double b = 3;
            double res = TPSiK_lab_1.Program.getHypotenuse(a, b);
            Assert.AreEqual(res, 3.61);
        }
        [TestMethod]
        public void getPerimeterTest()
        {
            double a = 2;
            double b = 3;
            double c = 2;
            double res = TPSiK_lab_1.Program.getPerimeter(a, b, c);
            Assert.AreEqual(res, 7);
        }
    }
}
