namespace Herald.Result
{
    public class Result
    {
        public Status Status { get; internal set; }
        public string Message { get; internal set; }
    }

    public class Result<T> where T : class
    {
        public Status Status { get; internal set; }
        public string Message { get; internal set; }
        public T Data { get; internal set; }

        public static implicit operator Result<T>(Result o)
        {
            return new Result<T>() { Status = o.Status, Message = o.Message };
        }
    }
}
