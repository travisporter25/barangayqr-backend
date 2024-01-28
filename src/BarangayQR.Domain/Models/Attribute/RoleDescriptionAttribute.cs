using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarangayQR.Domain.Models
{
    [AttributeUsage(AttributeTargets.Field)]
    public class RoleDescriptionAttribute : Attribute
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public RoleDescriptionAttribute(string category, string description) 
        {
            Category = category;
            Description = description;
        }
    }
}
