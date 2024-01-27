using BarangayQR.Domain.Models;

namespace BarangayQR.Domain.Resident
{
    public class PersonalInformationDomain : ResidentBase
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string? Suffix { get; set; }
        public string? NickName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public DateTime? BirthDate { get; set; }

    }
}
