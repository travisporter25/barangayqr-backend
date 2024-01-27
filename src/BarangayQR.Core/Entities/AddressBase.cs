using System.IO;
using System.Net;
using System.Xml.Linq;

namespace BarangayQR.Core.Entities;

public class AddressBase : EntitiesBase
{ 
    public long? AddressID { get; set; }
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
