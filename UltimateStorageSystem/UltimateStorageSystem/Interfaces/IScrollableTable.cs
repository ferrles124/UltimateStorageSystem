// ISCROLLABLETABLE.CS
// Defines the contract for any table that can be scrolled
// (used by Scrollbar to control and read the table's scroll position).

#nullable disable

namespace UltimateStorageSystem.Interfaces
{
    public interface IScrollableTable
    {
        // The current scroll index of the table
        int ScrollIndex { get; set; }

        // Returns the total number of (filtered) item entries in the table
        int GetItemEntriesCount();

        // Returns the number of rows visible at once in the table
        int GetVisibleRows();
    }
}
