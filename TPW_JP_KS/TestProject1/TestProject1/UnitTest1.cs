using TPW_JP_KS;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.div(10,5), 2);
        }

        public void Test2()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.sub(10, 5), 5);
        }

        public void Test3()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.mul(10, 5), 50);
        }
    }
}