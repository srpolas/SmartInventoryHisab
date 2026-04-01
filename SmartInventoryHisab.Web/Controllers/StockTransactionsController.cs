using Microsoft.AspNetCore.Mvc;
using SmartInventoryHisab.BLL;

namespace SmartInventoryHisab.Web.Controllers;

public class StockTransactionsController : Controller
{
    private readonly IStockService _stockService;

    public StockTransactionsController(IStockService stockService)
    {
        _stockService = stockService;
    }

    public async Task<IActionResult> Index()
    {
        var transactions = await _stockService.GetAllTransactionsAsync();
        return View(transactions);
    }
}
