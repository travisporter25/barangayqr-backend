namespace BarangayQR.Repository.Contract;

public class OrderItemEntity
{
    public string? OrderItemID { get; set; }
    public long? OrderItemNumber { get; set; } 
    public string? OrderItemName { get; set; }
    public string? OrderID { get; set; }
    public long? OrderNumber { get; set; }
    public int? LineNumber { get; set; }
    public string? ProductSKU { get; set; }
    public long? ProductNumber { get; set; }
    public string? ProductName { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? UnitPriceBeforeTax { get; set; }
    public bool PriceOverridden { get; set; }
    public long? ProductPriceList { get; set; }
    public string? ProductPriceListName { get; set; }
    public decimal? Tax { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? NetAmount { get; set; }
    public string? Remarks { get; set; }
    public string? PaymentReference { get; set; } 
    public long? SalesPerson { get; set; }
    public string? SalesPersoncode { get; set; }
    public string? SalesPersonName { get; set; } 
    public string? CustomerID { get; set; }
    public long? CustomerNumber { get; set; }
    public string? CustomerFirstName { get; set; }
    public string? CustomerLastName { get; set; }
    public string? CustomerFullName { get; set; }
    public string? CustomerMobile { get; set; }
    public string? CustomerEmail { get; set; }
    public string? AccountID { get; set; }
    public long? AccountNumber { get; set; }
    public string? AccountFirstName { get; set; }
    public string? AccountLastName { get; set; }
    public string? AccountFullName { get; set; }
    public string? AccountMobile { get; set; }
    public string? AccountEmail { get; set; }
    public bool IsActive { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }

}
