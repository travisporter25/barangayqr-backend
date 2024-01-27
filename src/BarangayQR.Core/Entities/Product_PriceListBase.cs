namespace BarangayQR.Core.Entities;

public class Product_PriceListBase : EntitiesBase
{
    public int? ProductPriceListID { get; set; } 
    public int? PriceList  { get; set;}
    public string? PriceListName { get; set;}
    public int? Product { get; set; }
    public string? ProductSKU { get; set;}
    public decimal? Price { get; set; }
    public decimal? Discount { get; set; } 
}
