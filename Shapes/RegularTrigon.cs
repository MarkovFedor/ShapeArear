namespace ShapeArear
{
    public class RegularTrigon : RegularShape
    {
        static readonly int TrigonSideCount = 3;

        public RegularTrigon(int sideLength)
            : base(sideLength, TrigonSideCount)
        {
        }
    }
}