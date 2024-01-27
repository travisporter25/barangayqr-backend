namespace BarangayQR.Core.Entities;

public class RelationEntitiesBase : EntitiesBase
{
    public long? RelationID { get; set; }
    public string? StringRelationID { get; set; }
    public long? PrimaryID { get; set; }
    public string? StringPrimaryID {  get; set; } 
    public long? ForeignID { get; set; }
    public string? StringForeignID { get; set; }  
}
