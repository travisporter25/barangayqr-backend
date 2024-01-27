﻿using BarangayQR.Domain.Models;

namespace BarangayQR.Domain.Resident
{
    public class AddressInformationDomain : ResidentBase
    {
        public string AddressType { get; set; }
        public string Barangay { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
    }
}
