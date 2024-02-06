namespace DrawingApplication.Tests
{
    [TestFixture]
    internal class CanvasTests
    {
        [Test]
        public void TheCanvasInitialisesWithNoWidgets()
        {
            var canvas = new Canvas();
            Assert.That(canvas.Widgets.ToList(), Has.Count.EqualTo(0));
        }

        [Test]
        public void WhenRectangleIsAddedCanvasHasOneWidget()
        {
            var canvas = new Canvas();
            canvas.AddRectangle(0, 0, 50, 100);
            Assert.That(canvas.Widgets.ToList(), Has.Count.EqualTo(1));
        }

        [Test]
        public void WhenSquareIsAddedCanvasHasOneWidget()
        {
            var canvas = new Canvas();
            canvas.AddSquare(0, 0, 50);
            Assert.That(canvas.Widgets.ToList(), Has.Count.EqualTo(1));
        }

        [Test]
        public void WhenEllipseIsAddedCanvasHasOneWidget()
        {
            var canvas = new Canvas();
            canvas.AddEllipse(0, 0, 50, 100);
            Assert.That(canvas.Widgets.ToList(), Has.Count.EqualTo(1));
        }

        [Test]
        public void WhenCircleIsAddedCanvasHasOneWidget()
        {
            var canvas = new Canvas();
            canvas.AddCircle(0, 0, 50);
            Assert.That(canvas.Widgets.ToList(), Has.Count.EqualTo(1));
        }

        [Test]
        public void WhenTextboxIsAddedCanvasHasOneWidget()
        {
            var canvas = new Canvas();
            canvas.AddTextbox(0, 0, 50, 100, "Test");
            Assert.That(canvas.Widgets.ToList(), Has.Count.EqualTo(1));
        }

        [Test]
        public void WhenAllShapeTypesAreAddedCanvasHasFiveWidgets()
        {
            var canvas = new Canvas();
            canvas.AddRectangle(0, 0, 50, 100);
            canvas.AddSquare(0, 0, 50);
            canvas.AddEllipse(0, 0, 50, 100);
            canvas.AddCircle(0, 0, 50);
            canvas.AddTextbox(0, 0, 50, 100, "Test");
            Assert.That(canvas.Widgets.ToList(), Has.Count.EqualTo(5));
        }
    }
}
