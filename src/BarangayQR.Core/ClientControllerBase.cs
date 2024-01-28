using BarangayQR.Core.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
namespace BarangayQR.Core
{
    public class ClientControllerBase : ControllerBase
    {
        public Guid BranchId
        {
            get
            {
                Guid retVal = ((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "branchId").Value.EnsureGuid();
                return retVal;
            }
        }
        public Guid ClientId
        {
            get
            {
                Guid retVal = ((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "clientId").Value.EnsureGuid();
                return retVal;
            }
        }
        public Guid UserId
        {
            get
            {
                Guid retVal = ((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "userId").Value.EnsureGuid();
                return retVal;
            }
        }
    }
}
