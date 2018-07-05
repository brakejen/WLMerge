using System;
using System.Collections.Generic;
using System.Linq;

namespace WLMerge
{
    /// <summary>
    /// A list of Inventory Items for a Bricklink Wanted List. 
    /// The list has the following notable properties:
    ///     * Can be databound (inerits BindingList)
    ///     * Can be sorted in a gridview (extension with SortableBindningList)
    ///     * Knows how many items (elements in list) AND pieces in total it represent, with
    ///         exception: only if added using Insert(InventoryItem[] items). All other operators
    ///         will not update pieces in total 
    ///     * Insert(InventoryItem[] items) will insert new items and merge existing ones, ie
    ///       it provides the main functionality of the app, as in WL*merge*
    /// </summary>
    public class InventoryItemList : SortableBindingList<InventoryItem>
    {
        public event EventHandler<ItemChangedEventArgs> ItemChanged;

        protected virtual void OnItemChanged(object sender, ItemChangedEventArgs e)
        {
            var handler = ItemChanged; // Avoid race condition
            handler?.Invoke(sender, e); // Invoke handler
        }

        /// <summary>
        /// The total amount of pieces this list hold (based on MINQTY)
        /// </summary>
        public int PieceCount { get; private set; }

        /// <summary>
        /// The total amount of items this list hold (unique pieces with same colors)
        /// </summary>
        public int ItemCount { get { return Count; } }

        /// <summary>
        /// Create an empty InventoryItemList
        /// </summary>
        public InventoryItemList() : base(new List<InventoryItem>())
        {
        }

        /// <summary>
        /// Return this list as the object representation of an Inventory, serializable to XML
        /// </summary>
        /// <returns></returns>
        public Inventory ToInventory()
        {
            return new Inventory() { Items = this.ToArray() };
        }

        /// <summary>
        /// Merge items from an inventory to this list of items. If an item already exist, it will be merged.
        /// If item does not exist, it will be added as is. TotalPieces will be updated accordingly.
        /// </summary>
        /// <param name="newItems">Array of items to merge inte main list</param>
        public void Insert(InventoryItem[] newItems)
        {
            // For each new item to insert...
            foreach (var newItem in newItems)
            {
                var combined = false;

                // Go through all existing items
                for(int i = 0; i<Count; i++)
                {
                    var oldItem = this[i];

                    // Equality based on ITEMID and COLOR combined
                    if (oldItem.ItemId == newItem.ItemId && oldItem.Color == newItem.Color)
                    {
                        // New item already in list! Combine old and new one to make the updated item
                        var itemsCombined = oldItem + newItem;
                        SetItem(i, itemsCombined);

                        // Signal listeners that item has changed
                        OnItemChanged(this, new ItemChangedEventArgs(i, oldItem, itemsCombined));

                        // We're done searching
                        combined = true;
                        break;
                    }
                }

                if (!combined)
                {
                    // Item not found, new one so add it 
                    Add(newItem);
                }

                // Adjust piece count
                PieceCount += newItem.MinQty;
            }
        }
    }
}
