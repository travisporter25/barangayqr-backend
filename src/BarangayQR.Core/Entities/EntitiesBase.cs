namespace BarangayQR.Core.Entities;

public class EntitiesBase
{
    public bool? IsActive { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
