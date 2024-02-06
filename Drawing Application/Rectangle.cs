namespace DrawingApplication
{
    public class Rectangle : IShape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
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

        public override string ToString()
        {
            return $"width={width} height={height}";
        }
    }
}
