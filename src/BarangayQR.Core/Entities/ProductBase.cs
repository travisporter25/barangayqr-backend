namespace BarangayQR.Core.Entities;

public class ProductBase : EntitiesBase
{
    public int? ProductNumber { get; set; }
    public string? SKU { get; set; }
    public string? Description { get; set; }
    public string? LongDescription { get; set; }
    public int? ParentProduct { get; set; }
    public string? ParentProductSKU { get; set; }
    public int? ProductStructure { get; set; }
    public string? ProductStructureName { get; set; } 
}
