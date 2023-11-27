using Unit_Testing;

namespace Debugging_Unit_Testing.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWith3And4()
        {
            //Arrange
            var stats = new Stats();
            //Act
            stats.Add(3);
            stats.Add(4);

            //Assert
            Assert.AreEqual(2, stats.Count);
            Assert.AreEqual(7, stats.Sum);
            Assert.AreEqual(4, stats.Max);
            Assert.AreEqual(3, stats.Min);
            Assert.AreEqual(3.5, stats.Mean, 0.0001);

        }
    }
}