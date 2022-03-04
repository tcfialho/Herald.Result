namespace Herald.Result
{
    public class Result
    {
        public Status Status { get; internal set; }
        internal string Message { get; set; }
    }

    public class Result<T> where T : class
    {
        public Status Status { get; internal set; }
        internal string Message { get; set; }
        internal T Data { get; set; }

        public static implicit operator Result<T>(Result o)
        {
            return new Result<T>() { Status = o.Status, Message = o.Message };
        }
    }
}
