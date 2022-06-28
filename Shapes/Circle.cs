using ShapeArear.Exceptions;

namespace ShapeArear
{
    public class Circle : Shape
    {
        public int RadiusLength { get; protected set; }

        public Circle(int radiusLength)
        {
            if (radiusLength <= 0)
                throw new IncorrectSideLengthException("Радиус круга не может быть отрицательным или 0");
            RadiusLength = radiusLength;
            CountArea();
        }

        public void SetRadiusLength(int value)
        {
            if (value <= 0) throw new IncorrectSideLengthException("Длина радиуса не может быть меньше 0");
            RadiusLength = value;
            CountArea();
        }

        protected override double CountArea()
        {
            Area = Math.Pow(RadiusLength, 2) * Math.PI;
            return Area;
        }
    }
}