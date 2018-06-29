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
        public static int MergeItems(ref SortableBindingList<InventoryItem> masterList, InventoryItem[] items)
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
        private static int AddOrUpdate(InventoryItem newItem, ref SortableBindingList<InventoryItem> list)
        {
            foreach (var element in list)
            {
                // Equality based on ITEMID and COLOR combined
                if (element.ItemId == newItem.ItemId && element.Color == newItem.Color)
                {
                    // Combine old and new one to make the updated item
                    var itemsCombined = InventoryList.ItemsCombine(element, newItem);

                    // Remove old one
                    list.Remove(element);

                    // Add updated item to replace old one
                    list.Add(itemsCombined);

                    // Return piece count of new one, ie number of added pieces
                    return newItem.MinQty;
                }
            }

            // Item not found, new one so add it and return amount of pieces it adds
            list.Add(newItem);
            return newItem.MinQty;
        }

        private static InventoryItem ItemsCombine(InventoryItem i1, InventoryItem i2)
        {
            var iCombined = new InventoryItem
            {
                ItemId = i2.ItemId,
                Color = i2.Color,
                ItemType = i2.ItemType,
                Notify = i2.Notify,
                Remarks = string.Format("{0} || {1}", i1.Remarks, i2.Remarks),
                MinQty = i1.MinQty + i2.MinQty
            };

            return iCombined;
        }
    }
}
