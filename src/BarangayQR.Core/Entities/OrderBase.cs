namespace BarangayQR.Core.Entities;

public class OrderBase : EntitiesBase
{
    public long? OrderID { get; set; }
    public string? OrderNumber { get; set; }
    public string? OrderName { get; set; }
    public DateTime? OrderDate { get; set; }
    public bool? IsApprove { get; set; }
    public string? ApproveBy { get; set; } 
    public int? Branch { get; set; }
    public string? BranchCode { get; set; }
    public string? BranchName { get; set; }

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
    public string? Remarks { get; set; } 
    public decimal? TotalTax { get; set; }
    public decimal? TotalDiscount { get; set; }
    public decimal? TotalDiscountPercent { get; set; }
    public decimal? TotalGrossAmount { get; set; }
    public decimal? TotalNetAmount { get; set; }
    public int? SalesPerson { get; set; }
    public string? SalesPersoncode { get; set; }
    public string? SalesPersonName { get; set; }
    public int? PaymentMethod { get; set; }
    public string? PaymentMethodName { get; set; } 
}
