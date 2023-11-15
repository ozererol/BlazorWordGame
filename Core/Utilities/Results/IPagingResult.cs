using System.Collections.Generic;

namespace blazorWords.Core.Utilities.Results
{
    public class IPagingResult<T> : IResult
    {
        /// <summary>
        /// data list
        /// </summary>
        List<T> Data { get; }

        /// <summary>
        /// total number of records
        /// </summary>
        int TotalItemCount { get; }
    }
}