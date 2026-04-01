using SmartInventoryHisab.Model;

namespace SmartInventoryHisab.BLL;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<Product?> GetProductByIdAsync(int id);
    Task CreateProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(int id);
}

public interface ISaleService
{
    Task<IEnumerable<Sale>> GetAllSalesAsync();
    Task<Sale?> GetSaleByIdAsync(int id);
    Task<bool> RecordSaleAsync(Sale sale);
    Task DeleteSaleAsync(int id);
}

public interface IPurchaseService
{
    Task<IEnumerable<Purchase>> GetAllPurchasesAsync();
    Task<Purchase?> GetPurchaseByIdAsync(int id);
    Task RecordPurchaseAsync(Purchase purchase);
    Task DeletePurchaseAsync(int id);
}

public interface IStockService
{
    Task<IEnumerable<StockTransaction>> GetAllTransactionsAsync();
}
