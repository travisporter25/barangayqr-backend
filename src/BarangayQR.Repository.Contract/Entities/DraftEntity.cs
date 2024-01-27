namespace BarangayQR.Repository.Contract;

public class DraftEntity
{
    public string? DraftID { get; set; }
    public long? DraftNumber { get; set; }
    public string? DraftName { get; set; }
    public DateTime? DraftDate { get; set; }
    public int? DraftDocumentType { get; set; }
    public string? DraftDocumentTypeName { get; set; }
    public string? DraftDocumentID { get; set; }
    public long? DraftDocumentNumber { get; set; }
    public bool IsApprove { get; set; }
    public bool ApproveBy { get; set; }
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
