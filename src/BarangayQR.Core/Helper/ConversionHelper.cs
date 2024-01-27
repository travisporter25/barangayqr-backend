
namespace BarangayQR.Core.Helper
{
    public static class ConversionHelper
    {
        public static Guid EnsureGuid(this object obj)
        {
            Guid retVal;
            if (Guid.TryParse(obj.EnsureString(), out retVal))
            {
                return retVal;
            }
            else
            {
                return Guid.Empty;
            }
        }
        public static string EnsureString(this object obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            else
            {
                return obj.ToString();
            }
        }
    }
}
