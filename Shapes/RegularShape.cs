using ShapeArear.Exceptions;

namespace ShapeArear
{
    public class RegularShape : Shape
    {
        public int SideLength { get; set; }

        public int SideCount { get; set; }

        public RegularShape(int sideLength, int sideCount)
        {
            SideLength = sideLength;
            SideCount = sideCount;
            CountArea();
        }

        public void SetSideCount(int value)
        {
            if (value <= 0) throw new IncorrectSidesCountException("Столько сторон быть не может");
            SideCount = value;
            CountArea();
        }

        public void SetSideLength(int value)
        {
            if (value <= 0) throw new IncorrectSideLengthException("Длина стороны такой быть не может");
            SideLength = value;
            CountArea();
        }

        protected override double CountArea()
        {
            Area = ((SideCount * Math.Pow(SideLength, 2)) / (4 * Math.Tan(Math.PI / SideCount)));
            return Area;
        }
    }
}