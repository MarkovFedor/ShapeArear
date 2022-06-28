using System.Globalization;
using ShapeArear.Exceptions;

namespace ShapeArear
{
    public class Trigon: Shape
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        public bool IsRegularTrigon { get; protected set; }

        public Trigon(int firstSide, int secondSide, int thirdSide)
        {
            CheckCorrect(firstSide, secondSide, thirdSide);
            CheckIsRegular(firstSide, secondSide, thirdSide);
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            CountArea();
        }

        private void CheckCorrect(int firstSide, int secondSide, int thirdSide)
        {
            if (firstSide + secondSide < thirdSide || firstSide + thirdSide < secondSide ||
                thirdSide + secondSide < firstSide) throw new IncorrectTrigonParameterException("Неправильные длины сторон");
        }
        protected override double CountArea()
        {
            double halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            Area = Math.Sqrt(halfPerimeter*(halfPerimeter - FirstSide)*(halfPerimeter-SecondSide)*(halfPerimeter-ThirdSide));
            return Area;
        }

        private void CheckIsRegular(int firstSide, int secondSide, int thirdSide)
        {
            IsRegularTrigon = (firstSide == secondSide && secondSide == thirdSide);
        }
    }
}

