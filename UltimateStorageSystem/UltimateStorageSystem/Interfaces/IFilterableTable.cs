// IFILTERABLETABLE.CS
// Defines the contract for any table that can be filtered and sorted
// (used by SearchBox to apply text-based filtering and sorting).

#nullable disable

namespace UltimateStorageSystem.Interfaces
{
    public interface IFilterableTable
    {
        // The current scroll index of the table (reset to 0 after filtering)
        int ScrollIndex { get; set; }

        // Filters the table's items based on the given search text
        void FilterItems(string searchText);

        // Sorts the table's items by the given column name and direction
        void SortItemsBy(string sortBy, bool ascending);
    }
}
