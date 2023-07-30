using Business.Definitions;
using Business.Implementations;

namespace TestProject
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
            Assert.AreEqual(1, 1);
            Assert.Pass();
        }
    }
}