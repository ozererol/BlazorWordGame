namespace blazorWords.Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message)
            : this(success)
        {
            Message = message; 
        }

        public Result(bool success, string message, string exceptionType, string exceptionMessage)
            : this(success)
        {
            Message = message;
            ExceptionType = exceptionType;
            ExceptionMessage = exceptionMessage;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
        public string ExceptionType { get; }
        public string ExceptionMessage { get; } 
    }
}
