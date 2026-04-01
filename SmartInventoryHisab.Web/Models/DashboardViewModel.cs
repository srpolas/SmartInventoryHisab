using SmartInventoryHisab.Model;

namespace SmartInventoryHisab.Web.Models;

public class DashboardViewModel
{
    public int TotalProducts { get; set; }
    public int LowStockCount { get; set; }
    public int OlderThan6MonthsCount { get; set; }
    public int RecentlyAddedCount { get; set; }
    public int RecentlySoldTotal { get; set; }
    
    public IEnumerable<Product> LatestProducts { get; set; } = new List<Product>();
    public IEnumerable<Sale> RecentSales { get; set; } = new List<Sale>();
}
