namespace DrawingApplication.Tests
{
    [TestFixture]
    public class TextboxTests
    {
        [TestCase(0, 0, "", 0, 0, "")]
        [TestCase(10, 30, "Test Case", 10, 30, "Test Case")]
        public void ATextboxCreatedWithPositiveDimensionsHasThoseValuesSet(int inputWidth, int inputHeight, string inputText, int expectedWidth, int expectedHeight, string expectedText)
        {
            var textbox = new Textbox(inputWidth, inputHeight, inputText);
            CheckAssertionsOnTextbox(textbox, expectedWidth, expectedHeight, expectedText);
        }

        [TestCase(-10, -30, "Test Case", 0, 0, "Test Case")]
        [TestCase(-10, 30, "Test Case", 0, 30, "Test Case")]
        [TestCase(10, -30, "Test Case", 10, 0, "Test Case")]
        public void ATextboxCreatedWithNegativeDimensionsHasThoseValuesSetToZero(int inputWidth, int inputHeight, string inputText, int expectedWidth, int expectedHeight, string expectedText)
        {
            var textbox = new Textbox(inputWidth, inputHeight, inputText);
            CheckAssertionsOnTextbox(textbox, expectedWidth, expectedHeight, expectedText);
        }

        [TestCase(0, 0, "", 0, 0, "")]
        [TestCase(10, 30, "Test Case", 10, 30, "Test Case")]
        public void ATextboxUpdatedWithPositiveDimensionsHasThoseValuesSet(int inputWidth, int inputHeight, string inputText, int expectedWidth, int expectedHeight, string expectedText)
        {
            var textbox = new Textbox(100, 200, "Dummy Text");
            textbox.Width = inputWidth;
            textbox.Height = inputHeight;
            textbox.Text = inputText;
            CheckAssertionsOnTextbox(textbox, expectedWidth, expectedHeight, expectedText);
        }

        [TestCase(-10, -30, "Test Case", 0, 0, "Test Case")]
        [TestCase(10, -30, "Test Case", 10, 0, "Test Case")]
        [TestCase(-10, 30, "Test Case", 0, 30, "Test Case")]
        public void ATextboxUpdatedWithNegativeDimensionsHasThoseValuesSetToZero(int inputWidth, int inputHeight, string inputText, int expectedWidth, int expectedHeight, string expectedText)
        {
            var textbox = new Textbox(100, 200, "Dummy Text");
            textbox.Width = inputWidth;
            textbox.Height = inputHeight;
            textbox.Text = inputText;
            CheckAssertionsOnTextbox(textbox, expectedWidth, expectedHeight, expectedText);
        }

        [TestCase(0, 0, "", 0, 0, "")]
        [TestCase(10, 30, "Test Case", 10, 30, "Test Case")]
        public void ToStringShouldReturnADescriptionOfTheShape(int inputWidth, int inputHeight, string inputText, int expectedWidth, int expectedHeight, string expectedText)
        {
            var textbox = new Textbox(inputWidth, inputHeight, inputText);
            Assert.That(textbox.ToString(), Is.EqualTo($"width={expectedWidth} height={expectedHeight} Text=\"{expectedText}\""));
        }

        private static void CheckAssertionsOnTextbox(Textbox textbox, int expectedWidth, int expectedHeight, string expectedText)
        {
            Assert.Multiple(() =>
            {
                Assert.That(textbox.Width, Is.EqualTo(expectedWidth));
                Assert.That(textbox.Height, Is.EqualTo(expectedHeight));
                Assert.That(textbox.Text, Is.EqualTo(expectedText));
            });
        }
    }
}
