using BarangayQR.Core.Helper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
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
                Guid retVal = ((ClaimsIdentity)User.Identity).Claims.ToArray()[1].Value.EnsureGuid();
                return retVal;
            }
        }
        public Guid UserId
        {
            get
            {
                Guid retVal = ((ClaimsIdentity)User.Identity).Claims.ToArray()[0].Value.EnsureGuid();
                return retVal;
            }
        }
    }
}
