namespace BarangayQR.Repository.Contract;

public class InvoiceEntity
{
    public string? InvoiceID { get; set; }
    public long? InvoiceNumber { get; set; }
    public string? InvoiceName { get; set; }
    public DateTime? InvoiceDate { get; set; }
    public bool IsApprove { get; set; }
    public bool ApproveBy { get; set; }
    public string? OrderID { get; set; }
    public long? OrderNumber { get; set; }
    public long? Branch { get; set; }
    public string? BranchCode { get; set; }
    public string? BranchName { get; set; }
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
    public string? Remarks { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? TotalGrossAmount { get; set; }
    public decimal? TotalNetAmount { get; set; }
    public long? PaymentMethod { get; set; }
    public string? PaymentMethodName { get; set; }
    public long? SalesPerson { get; set; }
    public string? SalesPersoncode { get; set; }
    public string? SalesPersonName { get; set; }
    public bool IsActive { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
