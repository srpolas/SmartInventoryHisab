using SmartInventoryHisab.DAL;
using SmartInventoryHisab.Model;

namespace SmartInventoryHisab.BLL;

public class StockService : IStockService
{
    private readonly IUnitOfWork _unitOfWork;

    public StockService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<StockTransaction>> GetAllTransactionsAsync()
    {
        return await _unitOfWork.StockTransactions.GetAllAsync(t => t.Product!);
    }
}
