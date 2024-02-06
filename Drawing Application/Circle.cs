namespace DrawingApplication
{
    public class Circle : IShape
    {
        private int size;

        public Circle(int size)
        {
            Size = size;
        }

        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value.PositiveValueOrZero();
            }
        }

        public override string ToString()
        {
            return $"size={size}";
        }
    }
}
