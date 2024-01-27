namespace BarangayQR.Core.Helper;

public static class PaginationHelper
{
    public static int GetTotalPages(int totalItems, int pageSize)
    {
        // Ensure the pageSize is not zero to avoid division by zero
        if (pageSize <= 0)
        {
            return 0;
        }

        // Calculate the total pages
        int totalPages = totalItems / pageSize;

        // If there are remaining items, add one more page for them
        if (totalItems % pageSize > 0)
        {
            totalPages++;
        }

        return totalPages;
    }
}
