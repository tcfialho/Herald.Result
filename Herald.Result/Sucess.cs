namespace Herald.Result
{
    public class Sucess : Result
    {
        public override Status Status { get; } = Status.Sucess;

        public object Value => _value;

        public Sucess(object data)
        {
            _value = data;
        }
    }

    public class Sucess<T> : Result<T> where T : class
    {
        public override Status Status { get; } = Status.Sucess;

        public T Value => (T)_value;

        public Sucess(T data)
        {
            _value = data;
        }
    }
}
