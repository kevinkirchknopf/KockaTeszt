using Teglatest_Teszt;
namespace TeglaTeszt
{
    [TestClass]
    public class UnitTest1
    {
        //ARRANGE
        TeglaTest teglatest = new TeglaTest();
        [TestMethod]
        public void Terfogat()
        {
            int Expected = 1000;

            Assert.AreEqual(Expected, teglatest.Terfogat(10, 10, 10));
        }

        [TestMethod]
        public void Felszin()
        {
            int Expected = 600;

            Assert.AreEqual(Expected, teglatest.Felszin(10, 10, 10));
        }

        [TestMethod]
        public void Atlo()
        {
            double Expected = 17.32;

            Assert.AreEqual(Expected, teglatest.Atlo(10, 10, 10));
        }
    }
}