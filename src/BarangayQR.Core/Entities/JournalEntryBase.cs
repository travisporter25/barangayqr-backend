namespace BarangayQR.Core.Entities;

public class JournalEntryBase : EntitiesBase
{
    public long? JournalEntryID { get; set; }
    public string? JournalEntryName { get; set; }
    public long? TransactionID { get; set; }
    public long? TransactionItemID { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string? Account { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public string? ReferenceID { get; set; }
    public string? Remarks { get; set; }
    public string? Status { get; set; }
}
