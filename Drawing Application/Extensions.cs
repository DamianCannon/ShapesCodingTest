namespace DrawingApplication
{
    public static class Extensions
    {
        public static int PositiveValueOrZero(this int value)
        {
            return value >= 0 ? value : 0;
        }
    }
}
