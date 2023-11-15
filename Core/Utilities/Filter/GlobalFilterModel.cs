using System.Collections.Generic;

namespace blazorWords.Core.Filter
{
    public class GlobalFilterModel
    {
        public IEnumerable<SortingUtility.SortingParams> SortingParams { set; get; }
        public IEnumerable<FilterUtility.FilterParams> FilterParam { get; set; }
        public IEnumerable<string> GroupingColumns { get; set; } = null;
        int pageNumber = 1;
        public int PageNumber { get { return pageNumber; } set { if (value > 1) pageNumber = value; } }

        int pageSize = 25;
        public int PageSize { get { return pageSize; } set { if (value > 1) pageSize = value; } }
    }
}
