namespace Herald.Result
{
    public class ResultStatus
    {
        public static Result NotFound(string message = default)
        {
            return new NotFound(message);
        }

        public static Result Fail(string message = default)
        {
            return new Fail(message);
        }

        public static Result Sucess()
        {
            return new Sucess(null);
        }

        public static Result<T> Sucess<T>(T data = default) where T : class
        {
            return new Sucess<T>(data);
        }
    }
}
