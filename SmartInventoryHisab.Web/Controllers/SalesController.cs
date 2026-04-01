using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartInventoryHisab.BLL;
using SmartInventoryHisab.Model;

namespace SmartInventoryHisab.Web.Controllers;

public class SalesController : Controller
{
    private readonly ISaleService _saleService;
    private readonly IProductService _productService;

    public SalesController(ISaleService saleService, IProductService productService)
    {
        _saleService = saleService;
        _productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        var sales = await _saleService.GetAllSalesAsync();
        return View(sales);
    }

    public async Task<IActionResult> Create()
    {
        var products = await _productService.GetAllProductsAsync();
        ViewBag.ProductId = new SelectList(products, "Id", "Name");
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Sale sale)
    {
        if (ModelState.IsValid)
        {
            var success = await _saleService.RecordSaleAsync(sale);
            if (success)
            {
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", "Insufficient stock or product not found.");
        }
        var products = await _productService.GetAllProductsAsync();
        ViewBag.ProductId = new SelectList(products, "Id", "Name", sale.ProductId);
        return View(sale);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var sale = await _saleService.GetSaleByIdAsync(id);
        if (sale == null) return NotFound();
        return View(sale);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _saleService.DeleteSaleAsync(id);
        return RedirectToAction(nameof(Index));
    }
}
