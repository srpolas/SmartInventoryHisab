using SmartInventoryHisab.DAL;
using SmartInventoryHisab.Model;

namespace SmartInventoryHisab.BLL;

public class PurchaseService : IPurchaseService
{
    private readonly IUnitOfWork _unitOfWork;

    public PurchaseService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Purchase>> GetAllPurchasesAsync()
    {
        return await _unitOfWork.Purchases.GetAllAsync(p => p.Product!);
    }

    public async Task<Purchase?> GetPurchaseByIdAsync(int id)
    {
        return await _unitOfWork.Purchases.GetByIdAsync(id, p => p.Product!);
    }

    public async Task RecordPurchaseAsync(Purchase purchase)
    {
        var product = await _unitOfWork.Products.GetByIdAsync(purchase.ProductId);
        if (product != null)
        {
            product.CurrentStock += purchase.Quantity;
            _unitOfWork.Products.Update(product);

            await _unitOfWork.Purchases.AddAsync(purchase);
            await _unitOfWork.CompleteAsync();

            await _unitOfWork.StockTransactions.AddAsync(new StockTransaction
            {
                ProductId = purchase.ProductId,
                Quantity = purchase.Quantity,
                TransactionType = TransactionType.Purchase,
                TransactionDate = purchase.PurchaseDate,
                ReferenceId = $"PUR-{purchase.Id}"
            });

            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeletePurchaseAsync(int id)
    {
        var purchase = await _unitOfWork.Purchases.GetByIdAsync(id);
        if (purchase != null)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(purchase.ProductId);
            if (product != null)
            {
                product.CurrentStock -= purchase.Quantity;
                _unitOfWork.Products.Update(product);
            }

            _unitOfWork.Purchases.Delete(purchase);
            await _unitOfWork.CompleteAsync();
        }
    }
}
