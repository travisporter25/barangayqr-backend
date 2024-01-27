namespace BarangayQR.Core.Entities;

public class BranchBase : EntitiesBase
{
    public int? BranchID { get; set; }
    public string? BranchCode { get; set; }
    public string? BranchName { get; set; } 
    public DateTime? StartDate { get; set; } 
}
