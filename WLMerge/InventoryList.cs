using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLMerge
{
    public static class InventoryList
    {
        /// <summary>
        /// Merge items from an inventory to a master list with items. If an item already exist, it will be updated
        /// with respect to quantity (MINQTY) and remarks (REMARKS), ie quantity summed and remarks concatenated.
        /// If item does not exist, it will be added as is.
        /// </summary>
        /// <param name="masterList">Main list to add items to</param>
        /// <param name="items">Array of items to merge inte main list</param>
        /// <returns>The total number of pieces added to main list</returns>
        public static int MergeItems(ref SortableBindingList<INVENTORYITEM> masterList, INVENTORYITEM[] items)
        {
            int piecesTotal = 0;

            foreach (var item in items)
            {
                var piecesAdded = AddOrUpdate(item, ref masterList);
                piecesTotal += piecesAdded;
            }

            return piecesTotal;
        }

        // Add or update a new item to a list of items.
        // If the item exist (based on itemId and color) the old and new will be combined with respect to piece count and remarks (update)
        // If the item does not exist it will be added as is
        private static int AddOrUpdate(INVENTORYITEM newItem, ref SortableBindingList<INVENTORYITEM> list)
        {
            var found = false;
            var i = -1;
            INVENTORYITEM oldItem = new INVENTORYITEM();

            foreach (var element in list)
            {
                i++;

                // Equality based on ITEMID and COLOR combined
                if (element.ITEMID == newItem.ITEMID && element.COLOR == newItem.COLOR)
                {
                    // Store element found so we can combine old with new (counts and comments combined), then bail loop
                    oldItem = element;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                // Item not found, new one so add it
                list.Add(newItem);
                return newItem.MINQTY;
            }
            else
            {
                // Item found, remove it first
                list.RemoveAt(i);

                // Create new one by combining counts and comments
                var updatedItem = new INVENTORYITEM
                {
                    ITEMID = newItem.ITEMID,
                    COLOR = newItem.COLOR,
                    ITEMTYPE = newItem.ITEMTYPE,
                    NOTIFY = newItem.NOTIFY,
                    REMARKS = string.Format("{0} || {1}", oldItem.REMARKS, newItem.REMARKS),
                    MINQTY = oldItem.MINQTY + newItem.MINQTY
                };

                // Finally add the new combined item
                list.Add(updatedItem);
                return newItem.MINQTY;
            }
        }
    }
}
