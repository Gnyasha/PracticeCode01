using NUnit.Framework;

namespace PracticeCode01Tests
{
    public class Tests
    {
        private PracticeCode01.ArrangeElements? ArrangeElements;

        [SetUp]
        public void Setup()
        {
            ArrangeElements = new PracticeCode01.ArrangeElements();
        }

        [Test]
        public void Example01Test()
        {
            var actualArray = new int[] { 1, 5, 7, 3, 2, 1 };
            var expectedArray = new int[] { 1, 5, 3, 7, 1, 2 };

            var resultantArray = ArrangeElements?.ArrangePairs(actualArray);


            Assert.AreEqual(expectedArray, resultantArray);
        }


        [Test]
        public void Example02Test()
        {
            var actualArray = new int[] { 6, 7, 8, 8, 5, 3, 2 };
            var expectedArray = new int[] { 6, 7, 8, 8, 3, 5, 2 };

            var resultantArray = ArrangeElements?.ArrangePairs(actualArray);


            Assert.AreEqual(expectedArray, resultantArray);
        }


        [Test]
        public void Example03Test()
        {
            var actualArray = new int[] { 6, 8, 7};
            var expectedArray = new int[] { 6, 8, 7};

            var resultantArray = ArrangeElements?.ArrangePairs(actualArray);


            Assert.AreEqual(expectedArray, resultantArray);
        }

    }
}