namespace DrawingApplication.Tests
{
    [TestFixture]
    public class EllipseTests
    {
        [TestCase(0, 0, 0, 0)]
        [TestCase(10, 30, 10, 30)]
        public void AnEllipseCreatedWithPositiveDimensionsHasThoseValuesSet(int inputDiameterH, int inputDiameterV, int expectedDiameterH, int expectedDiameterV)
        {
            var ellipse = new Ellipse(inputDiameterH, inputDiameterV);
            CheckAssertionsOnEllipse(ellipse, expectedDiameterH, expectedDiameterV);
        }

        [TestCase(-10, -30, 0, 0)]
        [TestCase(-10, 30, 0, 30)]
        [TestCase(10, -30, 10, 0)]
        public void AnEllipseCreatedWithNegativeDimensionsHasThoseValuesSetToZero(int inputDiameterH, int inputDiameterV, int expectedDiameterH, int expectedDiameterV)
        {
            var ellipse = new Ellipse(inputDiameterH, inputDiameterV);
            CheckAssertionsOnEllipse(ellipse, expectedDiameterH, expectedDiameterV);
        }

        [TestCase(0, 0, 0, 0)]
        [TestCase(10, 30, 10, 30)]
        public void AnEllipseUpdatedWithPositiveDimensionsHasThoseValuesSet(int inputDiameterH, int inputDiameterV, int expectedDiameterH, int expectedDiameterV)
        {
            var ellipse = new Ellipse(100, 200);
            ellipse.DiameterH = inputDiameterH;
            ellipse.DiameterV = inputDiameterV;
            CheckAssertionsOnEllipse(ellipse, expectedDiameterH, expectedDiameterV);
        }

        [TestCase(-10, -30, 0, 0)]
        [TestCase(-10, 30, 0, 30)]
        [TestCase(10, -30, 10, 0)]
        public void AnEllipseUpdatedWithNegativeDimensionsHasThoseValuesSetToZero(int inputDiameterH, int inputDiameterV, int expectedDiameterH, int expectedDiameterV)
        {
            var ellipse = new Ellipse(100, 200);
            ellipse.DiameterH = inputDiameterH;
            ellipse.DiameterV = inputDiameterV;
            CheckAssertionsOnEllipse(ellipse, expectedDiameterH, expectedDiameterV);
        }

        [TestCase(0, 0, 0, 0)]
        [TestCase(10, 30, 10, 30)]
        public void ToStringShouldReturnADescriptionOfTheShape(int inputDiameterH, int inputDiameterV, int expectedDiameterH, int expectedDiameterV)
        {
            var ellipse = new Ellipse(inputDiameterH, inputDiameterV);
            Assert.That(ellipse.ToString(), Is.EqualTo($"diameterH={expectedDiameterH} diameterV={expectedDiameterV}"));
        }

        private static void CheckAssertionsOnEllipse(Ellipse ellipse, int expectedDiameterH, int expectedDiameterV)
        {
            Assert.Multiple(() =>
            {
                Assert.That(ellipse.DiameterH, Is.EqualTo(expectedDiameterH));
                Assert.That(ellipse.DiameterV, Is.EqualTo(expectedDiameterV));
            });
        }
    }
}
