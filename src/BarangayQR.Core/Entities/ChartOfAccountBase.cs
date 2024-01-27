namespace BarangayQR.Core.Entities;

public class ChartOfAccountBase : EntitiesBase
{
    public int? ChartOfAccountID { get; set; }
    public string? Account { get; set; }
    public string? AccountName { get; set; }
    public int? ChartOfAccountType { get; set; }
    public string? ChartOfAccountTypeName { get; set; }
    public string? ExternalCode { get; set; } 
}
