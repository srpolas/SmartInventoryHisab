using SmartInventoryHisab.Model;

namespace SmartInventoryHisab.DAL;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Product> Products { get; }
    IGenericRepository<Sale> Sales { get; }
    IGenericRepository<Purchase> Purchases { get; }
    IGenericRepository<StockTransaction> StockTransactions { get; }
    Task<int> CompleteAsync();
}

public class UnitOfWork : IUnitOfWork
{
    private readonly SmartInventoryDbContext _context;

    public UnitOfWork(SmartInventoryDbContext context)
    {
        _context = context;
        Products = new GenericRepository<Product>(_context);
        Sales = new GenericRepository<Sale>(_context);
        Purchases = new GenericRepository<Purchase>(_context);
        StockTransactions = new GenericRepository<StockTransaction>(_context);
    }

    public IGenericRepository<Product> Products { get; private set; }
    public IGenericRepository<Sale> Sales { get; private set; }
    public IGenericRepository<Purchase> Purchases { get; private set; }
    public IGenericRepository<StockTransaction> StockTransactions { get; private set; }

    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
