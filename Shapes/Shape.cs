namespace ShapeArear
{
    public abstract class Shape
    {
        public double Area { get; protected set; }

        protected abstract double CountArea();
    }
}