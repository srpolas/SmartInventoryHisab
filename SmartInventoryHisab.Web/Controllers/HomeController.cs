using Microsoft.AspNetCore.Mvc;
using SmartInventoryHisab.DAL;
using SmartInventoryHisab.Web.Models;

namespace SmartInventoryHisab.Web.Controllers;

public class HomeController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> Index()
    {
        var sixMonthsAgo = DateTime.UtcNow.AddMonths(-6);
        var thirtyDaysAgo = DateTime.UtcNow.AddDays(-30);

        var products = await _unitOfWork.Products.GetAllAsync();
        var sales = await _unitOfWork.Sales.GetAllAsync(s => s.Product!);

        var model = new DashboardViewModel
        {
            TotalProducts = products.Count(),
            LowStockCount = products.Count(p => p.CurrentStock < 5),
            OlderThan6MonthsCount = products.Count(p => p.CreatedAt < sixMonthsAgo),
            RecentlyAddedCount = products.Count(p => p.CreatedAt > thirtyDaysAgo),
            RecentlySoldTotal = sales.Where(s => s.SaleDate > thirtyDaysAgo).Sum(s => s.Quantity),
            
            LatestProducts = products.OrderByDescending(p => p.CreatedAt).Take(5),
            RecentSales = sales.OrderByDescending(s => s.SaleDate).Take(5)
        };

        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
