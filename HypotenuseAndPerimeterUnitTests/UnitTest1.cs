using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HypotenuseAndPerimeterUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2,3,3.61)]
        [DataRow(1,1,1.41)]
        [DataRow(2,1,2.24)]
        [DataRow(5,4,6.4)]
        public void getHypotenuseTest(double a, double b, double res)
        {   
            double actual = TPSiK_lab_1.Program.getHypotenuse(a, b);
            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        [DataRow(2,2,2,6)]
        [DataRow(1,5,3,9)]
        [DataRow(11,23,10,44)]
        public void getPerimeterTest(double a, double b, double c, double res)
        {
            double actual = TPSiK_lab_1.Program.getPerimeter(a, b, c);
            Assert.AreEqual(res, actual);
        }
    }
}
