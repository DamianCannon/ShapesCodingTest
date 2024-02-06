namespace DrawingApplication.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(0, 0)]
        [TestCase(10, 10)]
        public void ACircleCreatedWithPositiveDimensionsHasThoseValuesSet(int inputSize, int expectedSize)
        {
            var circle = new Circle(inputSize);
            Assert.That(circle.Size, Is.EqualTo(expectedSize));
        }

        [TestCase(-10, 0)]
        public void ACircleCreatedWithNegativeDimensionsHasThoseValuesSetToZero(int inputSize, int expectedSize)
        {
            var circle = new Circle(inputSize);
            Assert.That(circle.Size, Is.EqualTo(expectedSize));
        }

        [TestCase(0, 0)]
        [TestCase(10, 10)]
        public void ACircleUpdatedWithPositiveDimensionsHasThoseValuesSet(int inputSize, int expectedSize)
        {
            var circle = new Circle(100);
            circle.Size = inputSize;
            Assert.That(circle.Size, Is.EqualTo(expectedSize));
        }

        [TestCase(-10, 0)]
        public void ACircleUpdatedWithNegativeDimensionsHasThoseValuesSetToZero(int inputSize, int expectedSize)
        {
            var circle = new Circle(100);
            circle.Size = inputSize;
            Assert.That(circle.Size, Is.EqualTo(expectedSize));
        }

        [TestCase(0, 0)]
        [TestCase(10, 10)]
        public void ToStringShouldReturnADescriptionOfTheShape(int inputSize, int expectedSize)
        {
            var circle = new Circle(inputSize);
            Assert.That(circle.ToString(), Is.EqualTo($"size={expectedSize}"));
        }
    }
}
