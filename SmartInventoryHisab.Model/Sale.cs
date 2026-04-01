using System.ComponentModel.DataAnnotations;

namespace SmartInventoryHisab.Model;

public class Sale : IEntity
{
    public int Id { get; set; }
    
    [Required]
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    
    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }
    
    public DateTime SaleDate { get; set; } = DateTime.UtcNow;
}
