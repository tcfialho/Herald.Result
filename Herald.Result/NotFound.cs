namespace Herald.Result
{
    public class NotFound : Result
    {
        public override Status Status { get; } = Status.NotFound;

        public string Message => (string)_value;

        public NotFound(string message)
        {
            _value = message;
        }
    }
}
