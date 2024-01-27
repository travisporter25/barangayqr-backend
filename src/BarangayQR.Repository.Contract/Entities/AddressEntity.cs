using System.IO;
using System.Net;
using System.Xml.Linq;

namespace BarangayQR.Repository.Contract;

public class AddressEntity
{
    public Guid ParentID { get; set; }
    public long? ParentTableType { get; set; }
    public long? ParentTableTypeName { get; set; }
    public long? AddressID { get; set; }
    public long? AddressType { get; set; }
    public string? AddressTypeName { get; set; }
    public string? Region { get; set; }
    public string? Province { get; set; }
    public string? City { get; set; }
    public string? Barangay { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }
    public string? ContactName { get; set; }
    public string? Contact { get; set; }
    public bool IsActive { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
