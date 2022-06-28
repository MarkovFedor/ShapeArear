namespace ShapeArear.Exceptions
{
    public class IncorrectSidesCountException : Exception
    {
        public IncorrectSidesCountException(string message)
            : base(message)
        {
        }
    }
}