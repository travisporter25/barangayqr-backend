namespace BarangayQR.Core.Entities;

public class GeneralLedgerBase : EntitiesBase
{
    public int? GeneralLedgerID { get; set; }
    public string? Account { get; set; }
    public string? AccountName { get; set; }
    public int? ChartOfAccountType { get; set; }
    public string? ChartOfAccountTypeName { get; set; }
    public decimal? Balance { get; set; }
    public string? ReferenceID { get; set; }
}
