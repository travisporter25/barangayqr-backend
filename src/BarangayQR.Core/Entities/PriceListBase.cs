using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarangayQR.Core.Entities;

public class PriceListBase : EntitiesBase
{
    public int? PriceListID { get; set; }
    public string? PriceListCode { get; set; }
    public string? PriceListName { get; set; }
    public string? Description { get; set; }
    public int? PriceListStructure { get; set; }
    public string? PriceListStructureName { get; set; }  

}
