
using BarangayQR.Domain.Models.Enum;

namespace BarangayQR.Domain.Models
{
    public class User : BaseDomainModel
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public UserStatus Status { get; set; }
        public Roles Roles { get; set; }
        public Guid Token { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int Attempt { get; set; }

        public bool VerifyPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                Password = string.Empty;
            return Password.Equals(password);
        }
        public void SetPassword(string password)
        {
            Password = password;
        }
    }
}
