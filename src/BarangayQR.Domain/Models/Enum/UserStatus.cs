using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarangayQR.Domain.Models.Enum
{
    public enum UserStatus
    {
        Active = 1,
        NotActive = 2,
        Disabled = 3,
        ResetPasswordRequest = 4,
        Locked = 5
    }
}
