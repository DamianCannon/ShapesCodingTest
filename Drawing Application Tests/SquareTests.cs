namespace DrawingApplication.Tests
{
    [TestFixture]
    public class SquareTests
    {
        [TestCase(0, 0)]
        [TestCase(10, 10)]
        public void ASquareCreatedWithPositiveDimensionsHasThoseValuesSet(int inputSize, int expectedSize)
        {
            var square = new Square(inputSize);
            Assert.That(square.Size, Is.EqualTo(expectedSize));
        }

        [TestCase(-10, 0)]
        public void ASquareCreatedWithNegativeDimensionsHasThoseValuesSetToZero(int inputSize, int expectedSize)
        {
            var square = new Square(inputSize);
            Assert.That(square.Size, Is.EqualTo(expectedSize));
        }

        [TestCase(0, 0)]
        [TestCase(10, 10)]
        public void ASquareUpdatedWithPositiveDimensionsHasThoseValuesSet(int inputSize, int expectedSize)
        {
            var square = new Square(100);
            square.Size = inputSize;
            Assert.That(square.Size, Is.EqualTo(expectedSize));
        }

        [TestCase(-10, 0)]
        public void ASquareUpdatedWithNegativeDimensionsHasThoseValuesSetToZero(int inputSize, int expectedSize)
        {
            var square = new Square(100);
            square.Size = inputSize;
            Assert.That(square.Size, Is.EqualTo(expectedSize));
        }

        [TestCase(0, 0)]
        [TestCase(10, 10)]
        public void ToStringShouldReturnADescriptionOfTheShape(int inputSize, int expectedSize)
        {
            var square = new Square(inputSize);
            Assert.That(square.ToString(), Is.EqualTo($"size={expectedSize}"));
        }
    }
}
