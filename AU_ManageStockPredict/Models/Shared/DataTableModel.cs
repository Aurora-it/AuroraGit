
namespace Core.Models.Shared
{
    public class DataTableModel
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
    }

    public class DataTableCriteria
    {
        public int Draw { get; set; }
        public int PageStart { get; set; }
        public int PageSize { get; set; }
        public string SortField { get; set; }
        public string OrderType { get; set; }
    }
}
