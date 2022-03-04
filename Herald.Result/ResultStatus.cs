namespace Herald.Result
{
    public class ResultStatus
    {
        public static Result NotFound(string message = default)
        {
            return new Result() { Status = Status.NotFound, Message = message };
        }

        public static Result Fail(string message = default)
        {
            return new Result() { Status = Status.Fail, Message = message };
        }

        public static Result Sucess()
        {
            return new Result() { Status = Status.Sucess };
        }

        public static Result<T> Sucess<T>(T data = default) where T : class
        {
            return new Result<T>() { Status = Status.Sucess, Data = data };
        }
    }
}
