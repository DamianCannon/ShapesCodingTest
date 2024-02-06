namespace DrawingApplication
{
    public class Square : IShape
    {
        private int size;

        public Square(int size)
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
