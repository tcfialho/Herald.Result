namespace Herald.Result
{
    public class Result<T> where T : class
    {
        public virtual Status Status { get; }

        protected T _value;

        public T GetValue()
        {
            return _value;
        }

        public bool HasValue()
        {
            return _value != default(T);
        }

        public static implicit operator Result<T>(Result o)
        {
            return new Result<T>();
        }
    }

    public class Result : Result<object>
    {
    }
}
