using activitats;

namespace FirstRepository_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QuadrilateralArea_SquareCorrect()
        {
            double num = 5.25;
            double result = MenuAreas.QuadrilateralArea(num);
            Assert.AreEqual(27.56, result);
        }
        [TestMethod]
        public void QuadrilateralArea_RectangleCorrect()
        {
            double aristLong = 1.5, aristShort = 1;
            double result = MenuAreas.QuadrilateralArea(aristLong, aristShort);
            Assert.AreEqual(1.5, result);
        }
        [TestMethod]
        public void CercleArea_Correct()
        {
            double num = 8;
            double result = MenuAreas.CercleArea(num);
            Assert.AreEqual(201.06, result);
        }
        [TestMethod]
        public void PentagonArea_Correct()
        {
            double num = 10;
            double result = MenuAreas.PentagonArea(num);
            Assert.AreEqual(250, result);
        }
    }
}