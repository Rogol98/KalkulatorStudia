using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kalkulator.Tests
{
    [TestClass()]
    public class OperacjeMatematyczneTests
    {
        OperacjeMatematyczne op = new OperacjeMatematyczne();

        [TestMethod()]
        public void DodajTest()
        {
            Assert.AreEqual("5", op.Dodaj(2, "3"));
            Assert.AreEqual("0,75", op.Dodaj(0.5, "0,25"));
            Assert.AreEqual("5", op.Dodaj(5, "*1"));
        }

        [TestMethod()]
        public void OdejmijTest()
        {
            Assert.AreEqual("2", op.Odejmij(5, "3"));
            Assert.AreEqual("3", op.Odejmij(1, "-2"));
            Assert.AreEqual("5", op.Odejmij(5, "*1"));
            Assert.AreEqual("0,5", op.Odejmij(0.75, "0,25"));
        }

        [TestMethod()]
        public void MnozenieTest()
        {
            Assert.AreEqual("56", op.Mnozenie(8, "7"));
            Assert.AreEqual("1", op.Mnozenie(0.1, "10"));
            Assert.AreEqual("5", op.Mnozenie(5, "*2"));
        }

        [TestMethod()]
        public void DzielenieTest()
        {
            Assert.AreEqual("0,5", op.Dzielenie(2, "4"));
            Assert.AreEqual("9,8", op.Dzielenie(98, "10"));
            Assert.AreEqual("5", op.Dzielenie(5, "*1"));
        }

        [TestMethod()]
        public void PotegaTest()
        {
            Assert.AreEqual("32", op.Potega(2, "5"));
            Assert.AreEqual("125", op.Potega(5, "3"));
            Assert.AreEqual("1", op.Potega(1, "~5"));
        }

        [TestMethod()]
        public void ProcentTest()
        {
            Assert.AreEqual("50,00%", op.Procent(2, "4"));
            Assert.AreEqual("33,33%", op.Procent(1, "3"));
            Assert.AreEqual("0", op.Procent(0, "!1"));
        }

        [TestMethod()]
        public void PierwiastekTest()
        {
            for(double i = 1; i < 50; i += 0.5)
                Assert.AreEqual(i.ToString(), op.Pierwiastek(i*i));
        }

        [TestMethod()]
        public void ModuloTest()
        {
            Assert.AreEqual("1", op.Modulo(16, "15"));
            Assert.AreEqual("5", op.Modulo(20, "15"));
            Assert.AreEqual("5", op.Modulo(5, "!5"));
        }

        [TestMethod()]
        public void BinarnieTest()
        {
            Assert.AreEqual("101", op.Binary("5"));
            Assert.AreEqual("0", op.Binary("!123"));
        }

        [TestMethod()]
        public void SilniaTest()
        {
            Assert.AreEqual("6", op.Silnia("3"));
            Assert.AreEqual("1", op.Silnia("!3"));
        }
    }
}