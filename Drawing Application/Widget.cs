namespace DrawingApplication
{
    public class Widget
    {
        private readonly int x;
        private readonly int y;
        private readonly IShape shape;

        public Widget(int x, int y, IShape shape)
        {
            this.x = x;
            this.y = y;
            this.shape = shape ?? throw new ArgumentNullException(nameof(shape), "Invalid shape");
        }

        public override string ToString()
        {
            return $"{shape.GetType().Name} ({x},{y}) {shape}";
        }
    }
}
