using System.Collections.Generic;
using System.Linq;
namespace blazorWords.Core.Domain
{
    public class BaseResponse
    {
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; } 
        public string StackTrace { get; set; } 
        public bool Success { get; set; } 
        public bool IsBusinessException { get; set; }

    }
}