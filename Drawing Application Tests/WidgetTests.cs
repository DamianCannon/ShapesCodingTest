namespace DrawingApplication.Tests
{
    [TestFixture]
    public class WidgetTests
    {
        [Test]
        public void WidgetContainingARectangleReturnsRectangleDisplayString()
        {
            var rectangle = new Rectangle(50, 100);
            var widget = new Widget(0, 0, rectangle);
            Assert.That(widget.ToString(), Is.EqualTo("Rectangle (0,0) width=50 height=100"));
        }

        [Test]
        public void WidgetContainingASquareReturnsSquareDisplayString()
        {
            var square = new Square(50);
            var widget = new Widget(10, 10, square);
            Assert.That(widget.ToString(), Is.EqualTo("Square (10,10) size=50"));
        }

        [Test]
        public void WidgetContainingAnEllipseReturnsEllipseDisplayString()
        {
            var ellipse = new Ellipse(50, 100);
            var widget = new Widget(-10, -10, ellipse);
            Assert.That(widget.ToString(), Is.EqualTo("Ellipse (-10,-10) diameterH=50 diameterV=100"));
        }

        [Test]
        public void WidgetContainingACircleReturnsCircleString()
        {
            var circle = new Circle(50);
            var widget = new Widget(-10, 10, circle);
            Assert.That(widget.ToString(), Is.EqualTo("Circle (-10,10) size=50"));
        }

        [Test]
        public void WidgetContainingATextboxReturnsTextboxDisplayString()
        {
            var textbox = new Textbox(50, 100, "Test");
            var widget = new Widget(10, -10, textbox);
            Assert.That(widget.ToString(), Is.EqualTo("Textbox (10,-10) width=50 height=100 Text=\"Test\""));
        }

        [Test]
        public void WidgetCreatedWithNullShapeThrowsArgumentNullException()
        {
            Assert.That(() => { new Widget(0, 0, null); }, Throws.ArgumentNullException);
        }
    }
}
