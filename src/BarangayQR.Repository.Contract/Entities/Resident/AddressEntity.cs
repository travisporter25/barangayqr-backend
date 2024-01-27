using System.IO;
using System.Net;
using System.Xml.Linq;

namespace BarangayQR.Repository.Contract.Entities.Resident;

public class AddressEntity : EntityBase
{
    public Guid? AddressID { get; set; }
    public int? AddressType { get; set; }
    public string? AddressTypeName { get; set; }
    public string? Region { get; set; }
    public string? Province { get; set; }
    public string? City { get; set; }
    public string? Barangay { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }
    public string? ContactName { get; set; }
    public string? Contact { get; set; }
}
