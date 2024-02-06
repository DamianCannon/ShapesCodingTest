namespace DrawingApplication
{
    public class Canvas
    {
        private readonly List<Widget> widgets = new();

        public IEnumerable<Widget> Widgets
        {
            get
            {
                return widgets.AsEnumerable();
            }
        }

        public void AddRectangle(int x, int y, int width, int height)
        {
            AddWidget(x, y, new Rectangle(width, height));
        }

        public void AddSquare(int x, int y, int size)
        {
            AddWidget(x, y, new Square(size));
        }

        public void AddEllipse(int x, int y, int diameterH, int diamaterV)
        {
            AddWidget(x, y, new Ellipse(diameterH, diamaterV));
        }

        public void AddCircle(int x, int y, int size)
        {
            AddWidget(x, y, new Circle(size));
        }

        public void AddTextbox(int x, int y, int width, int height, string text)
        {
            AddWidget(x, y, new Textbox(width, height, text));
        }

        private void AddWidget(int x, int y, IShape shape)
        {
            widgets.Add(new Widget(x, y, shape));
        }
    }
}
