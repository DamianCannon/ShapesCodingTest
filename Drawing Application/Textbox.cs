namespace DrawingApplication
{
    public class Textbox : IShape
    {
        private int width;
        private int height;

        public Textbox(int width, int height, string text)
        {
            Width = width;
            Height = height;
            Text = text;
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value.PositiveValueOrZero();
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value.PositiveValueOrZero();
            }
        }

        public string Text { get; set; }

        public override string ToString()
        {
            return $"width={width} height={height} Text=\"{Text}\"";
        }
    }
}
