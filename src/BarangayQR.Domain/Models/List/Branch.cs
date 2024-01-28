using System.Globalization;
namespace BarangayQR.Domain.Models.List
{
    public static class Branch
    {
        public static List<OptionValue> GetBranchList()
        {
            return new List<OptionValue>() 
            {
                new OptionValue { BranchId = 1, BranchName = "Main Office" },
                new OptionValue { BranchId = 2, BranchName = "" },
                new OptionValue { BranchId = 3, BranchName = "" }
            };
        }


    }
}
