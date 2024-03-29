using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(40, 10)]
        [TestCase(37, 13)]
        [TestCase(25, 25)]
        [TestCase(50, 0)]
        [TestCase(100, -50)]
        public void SimpleAdditionOperations(int value, int valueb)
        {
            var result = MyMath.Operations.Add(value, valueb);
            Assert.AreEqual(50, result);
        }
    }
}