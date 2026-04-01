using SmartInventoryHisab.DAL;
using SmartInventoryHisab.Model;

namespace SmartInventoryHisab.BLL;

public class SaleService : ISaleService
{
    private readonly IUnitOfWork _unitOfWork;

    public SaleService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Sale>> GetAllSalesAsync()
    {
        return await _unitOfWork.Sales.GetAllAsync(s => s.Product!);
    }

    public async Task<Sale?> GetSaleByIdAsync(int id)
    {
        return await _unitOfWork.Sales.GetByIdAsync(id, s => s.Product!);
    }

    public async Task<bool> RecordSaleAsync(Sale sale)
    {
        var product = await _unitOfWork.Products.GetByIdAsync(sale.ProductId);
        if (product != null && product.CurrentStock >= sale.Quantity)
        {
            product.CurrentStock -= sale.Quantity;
            _unitOfWork.Products.Update(product);

            await _unitOfWork.Sales.AddAsync(sale);
            await _unitOfWork.CompleteAsync();

            await _unitOfWork.StockTransactions.AddAsync(new StockTransaction
            {
                ProductId = sale.ProductId,
                Quantity = -sale.Quantity,
                TransactionType = TransactionType.Sale,
                TransactionDate = sale.SaleDate,
                ReferenceId = $"SAL-{sale.Id}"
            });

            await _unitOfWork.CompleteAsync();
            return true;
        }
        return false;
    }

    public async Task DeleteSaleAsync(int id)
    {
        var sale = await _unitOfWork.Sales.GetByIdAsync(id);
        if (sale != null)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(sale.ProductId);
            if (product != null)
            {
                product.CurrentStock += sale.Quantity;
                _unitOfWork.Products.Update(product);
            }

            _unitOfWork.Sales.Delete(sale);
            await _unitOfWork.CompleteAsync();
        }
    }
}
