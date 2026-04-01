using System.ComponentModel.DataAnnotations;

namespace SmartInventoryHisab.Model;

public class Purchase : IEntity
{
    public int Id { get; set; }
    
    [Required]
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    
    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }
    
    public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;
}
