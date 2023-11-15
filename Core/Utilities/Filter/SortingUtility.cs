using System.Collections.Generic;

namespace blazorWords.Core.Filter
{
    public class SortingUtility
    {
        public enum SortOrders
        {
            Asc = 1,
            Desc = -1
            //Desc = 2
        }
        public class SortingParams
        {
            public SortOrders SortOrder { get; set; } = SortOrders.Asc;
            public string ColumnName { get; set; }
        }
    }
}
