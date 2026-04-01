using System.ComponentModel.DataAnnotations;

namespace SmartInventoryHisab.Model;

public class StockTransaction : IEntity
{
    public int Id { get; set; }
    
    [Required]
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    
    public int Quantity { get; set; } // Positive for Purchase, Negative for Sale
    
    public TransactionType TransactionType { get; set; }
    
    public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    
    public string? ReferenceId { get; set; } // Id of the Sale or Purchase record
}
