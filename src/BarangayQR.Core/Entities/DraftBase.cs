namespace BarangayQR.Core.Entities;

public class DraftBase : EntitiesBase
{
    public long? DraftID { get; set; }
    public string? DraftNumber { get; set; }
    public string? DraftName { get; set; }
    public DateTime? DraftDate { get; set; }
    public int? DraftDocumentType { get; set; }
    public string? DraftDocumentTypeName { get; set; }
    public long? DraftDocumentID { get; set; }
    public int? DraftDocumentNumber { get; set; }
    public bool IsApprove { get; set; }
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
    public decimal? TotalDiscount { get; set; }
    public decimal? TotalDiscountPercent { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? TotalGrossAmount { get; set; }
    public decimal? TotalNetAmount { get; set; }
    public int? PaymentMethod { get; set; }
    public string? PaymentMethodName { get; set; } 
    public int? SalesPerson { get; set; }
    public string? SalesPersoncode { get; set; }
    public string? SalesPersonName { get; set; } 
}
