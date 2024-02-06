namespace DrawingApplication
{
    public class Ellipse : IShape
    {
        private int diameterH;
        private int diameterV;

        public Ellipse(int diameterH, int diameterV)
        {
            DiameterH = diameterH;
            DiameterV = diameterV;
        }

        public int DiameterH
        {
            get
            {
                return diameterH;
            }

            set
            {
                diameterH = value.PositiveValueOrZero();
            }
        }

        public int DiameterV
        {
            get
            {
                return diameterV;
            }

            set
            {
                diameterV = value.PositiveValueOrZero();
            }
        }

        public override string ToString()
        {
            return $"diameterH={diameterH} diameterV={diameterV}";
        }
    }
}
