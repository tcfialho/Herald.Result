namespace Herald.Result
{
    public class Fail : Result
    {
        public override Status Status { get; } = Status.Fail;

        public string Message => (string)_value;

        public Fail(string message)
        {
            _value = message;
        }
    }
}
