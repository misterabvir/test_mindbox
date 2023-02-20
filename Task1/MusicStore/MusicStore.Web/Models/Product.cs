using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Web.Models;

public class Product
{
    public long? ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string ProductDescription { get; set;} = string.Empty;
    public string ProductCategory { get; set; } = string.Empty;

    [Column(TypeName = "decimal(8, 2)")]
    public decimal Price { get; set; }
}
