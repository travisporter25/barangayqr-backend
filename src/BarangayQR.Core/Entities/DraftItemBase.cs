namespace BarangayQR.Core.Entities;

public class DraftItemBase : EntitiesBase
{
    public long? DraftItemID { get; set; }
    public string? DraftItemNumber { get; set; }
    public string? DraftItemName { get; set; }
    public long? DraftID { get; set; }
    public string? DraftNumber { get; set; }
    public int? LineNumber { get; set; }
    public string? ProductSKU { get; set; }
    public int? ProductNumber { get; set; }
    public string? ProductName { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? UnitPriceBeforeTax { get; set; }
    public bool PriceOverridden { get; set; }
    public int? ProductPriceList { get; set; }
    public string? ProductPriceListName { get; set; }
    public decimal? Tax { get; set; }
    public decimal? Discount { get; set; }
    public decimal? DiscountPercent { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? NetAmount { get; set; }
    public string? Remarks { get; set; }
    public string? PaymentReference { get; set; }
    public int? PaymentMethod { get; set; }
    public string? PaymentMethodName { get; set; }

    public int? SalesPerson { get; set; }
    public string? SalesPersoncode { get; set; }
    public string? SalesPersonName { get; set; }

    public int? CustomerID { get; set; }
    public string? CustomerNumber { get; set; }
    public string? CustomerFirstName { get; set; }
    public string? CustomerLastName { get; set; }
    public string? CustomerFullName { get; set; }
    public string? CustomerMobile { get; set; }
    public string? CustomerEmail { get; set; }

    public int? AccountID { get; set; }
    public string? AccountNumber { get; set; }
    public string? AccountFirstName { get; set; }
    public string? AccountLastName { get; set; }
    public string? AccountFullName { get; set; }
    public string? AccountMobile { get; set; }
    public string? AccountEmail { get; set; } 

}
