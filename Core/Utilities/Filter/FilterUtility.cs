using System.Collections.Generic;

namespace blazorWords.Core.Filter
{
    public class FilterUtility
    {
        public enum FilterOptions
        {
            StartsWith = 1,
            EndsWith,
            Contains,
            DoesNotContain,
            IsEmpty,
            IsNotEmpty,
            IsGreaterThan,
            IsGreaterThanOrEqualTo,
            IsLessThan,
            IsLessThanOrEqualTo,
            IsEqualTo,
            IsNotEqualTo
        }

        public class FilterParams
        {
            public string ColumnName { get; set; } = string.Empty;
            public object FilterValue { get; set; } = string.Empty;
            public FilterOptions FilterOption { get; set; } = FilterOptions.Contains;
        }
    }
}
