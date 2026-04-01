using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartInventoryHisab.BLL;
using SmartInventoryHisab.Model;

namespace SmartInventoryHisab.Web.Controllers;

public class PurchasesController : Controller
{
    private readonly IPurchaseService _purchaseService;
    private readonly IProductService _productService;

    public PurchasesController(IPurchaseService purchaseService, IProductService productService)
    {
        _purchaseService = purchaseService;
        _productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        var purchases = await _purchaseService.GetAllPurchasesAsync();
        return View(purchases);
    }

    public async Task<IActionResult> Create()
    {
        var products = await _productService.GetAllProductsAsync();
        ViewBag.ProductId = new SelectList(products, "Id", "Name");
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Purchase purchase)
    {
        if (ModelState.IsValid)
        {
            await _purchaseService.RecordPurchaseAsync(purchase);
            return RedirectToAction(nameof(Index));
        }
        var products = await _productService.GetAllProductsAsync();
        ViewBag.ProductId = new SelectList(products, "Id", "Name", purchase.ProductId);
        return View(purchase);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var purchase = await _purchaseService.GetPurchaseByIdAsync(id);
        if (purchase == null) return NotFound();
        return View(purchase);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _purchaseService.DeletePurchaseAsync(id);
        return RedirectToAction(nameof(Index));
    }
}
