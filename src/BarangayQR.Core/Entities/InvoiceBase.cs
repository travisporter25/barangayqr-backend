namespace BarangayQR.Core.Entities;

public class InvoiceBase : EntitiesBase
{
    public long? InvoiceID { get; set; }
    public string? InvoiceNumber { get; set; }
    public string? InvoiceName { get; set; }
    public DateTime? InvoiceDate { get; set; }
    public bool IsApprove { get; set; }
    public bool ApproveBy { get; set; }
    public long? OrderID { get; set; }
    public string? OrderNumber { get; set; }

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
    public decimal? TotalGrossAmount { get; set; }
    public decimal? TotalNetAmount { get; set; }
    public int? PaymentMethod { get; set; }
    public string? PaymentMethodName { get; set; }
    public int? SalesPerson { get; set; }
    public string? SalesPersoncode { get; set; }
    public string? SalesPersonName { get; set; } 
}
