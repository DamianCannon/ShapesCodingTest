namespace DrawingApplication.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [TestCase(0, 0, 0, 0)]
        [TestCase(10, 30, 10, 30)]
        public void ARectangleCreatedWithPositiveDimensionsHasThoseValuesSet(int inputWidth, int inputHeight, int expectedWidth, int expectedHeight)
        {
            var rectangle = new Rectangle(inputWidth, inputHeight);
            CheckAssertionsOnRectangle(rectangle, expectedWidth, expectedHeight);
        }

        [TestCase(-10, -30, 0, 0)]
        [TestCase(-10, 30, 0, 30)]
        [TestCase(10, -30, 10, 0)]
        public void ARectangleCreatedWithNegativeDimensionsHasThoseValuesSetToZero(int inputWidth, int inputHeight, int expectedWidth, int expectedHeight)
        {
            var rectangle = new Rectangle(inputWidth, inputHeight);
            CheckAssertionsOnRectangle(rectangle, expectedWidth, expectedHeight);
        }

        [TestCase(0, 0, 0, 0)]
        [TestCase(10, 30, 10, 30)]
        public void ARectangleUpdatedWithPositiveDimensionsHasThoseValuesSet(int inputWidth, int inputHeight, int expectedWidth, int expectedHeight)
        {
            var rectangle = new Rectangle(100, 200);
            rectangle.Width = inputWidth;
            rectangle.Height = inputHeight;
            CheckAssertionsOnRectangle(rectangle, expectedWidth, expectedHeight);
        }

        [TestCase(-10, -30, 0, 0)]
        [TestCase(10, -30, 10, 0)]
        [TestCase(-10, 30, 0, 30)]
        public void ARectangleUpdatedWithNegativeDimensionsHasThoseValuesSetToZero(int inputWidth, int inputHeight, int expectedWidth, int expectedHeight)
        {
            var rectangle = new Rectangle(100, 200);
            rectangle.Width = inputWidth;
            rectangle.Height = inputHeight;
            CheckAssertionsOnRectangle(rectangle, expectedWidth, expectedHeight);
        }

        [TestCase(0, 0, 0, 0)]
        [TestCase(10, 30, 10, 30)]
        public void ToStringShouldReturnADescriptionOfTheShape(int inputWidth, int inputHeight, int expectedWidth, int expectedHeight)
        {
            var rectangle = new Rectangle(inputWidth, inputHeight);
            Assert.That(rectangle.ToString(), Is.EqualTo($"width={expectedWidth} height={expectedHeight}"));
        }

        private static void CheckAssertionsOnRectangle(Rectangle rectangle, int expectedWidth, int expectedHeight)
        {
            Assert.Multiple(() =>
            {
                Assert.That(rectangle.Width, Is.EqualTo(expectedWidth));
                Assert.That(rectangle.Height, Is.EqualTo(expectedHeight));
            });
        }
    }
}
