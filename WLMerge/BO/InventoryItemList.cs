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
    ///     * Insert(InventoryItem[] items) will insert new items and merge existing ones, ie
    ///       it provides the main functionality of the app, as in WL*merge*
    ///     * Emits events for adding and removing items, but not updated ones (could not get it to 
    ///       work with value before and after change which was needed - only after)
    /// </summary>
    public class InventoryItemList : SortableBindingList<InventoryItem>
    {        
        public event EventHandler<ItemRemovedEventArgs> ItemRemoved;
        public event EventHandler<ItemAddedEventArgs> ItemAdded;
     
        protected virtual void OnItemRemoved(object sender, ItemRemovedEventArgs e)
        {
            var handler = ItemRemoved; // Avoid race condition
            handler?.Invoke(sender, e); // Invoke handler
        }
        protected virtual void OnItemAdded(object sender, ItemAddedEventArgs e)
        {
            var handler = ItemAdded; // Avoid race condition
            handler?.Invoke(sender, e); // Invoke handler
        }
        
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
        /// Add an item to this list. Replaces the base.Add() and notifies 
        /// any listeners upon the change.
        /// </summary>
        /// <param name="item">The item to add</param>
        public new void Add(InventoryItem item)
        {
            base.Add(item);
            OnItemAdded(this, new ItemAddedEventArgs(Count, item));
        }

        /// <summary>
        /// Remove an item from this list. Replaces the base.RemoveItem() and notifies
        /// any listeners upon the change.
        /// </summary>
        /// <param name="i">The index of the item to remove</param>
        protected override void RemoveItem(int i)
        {
            var item = this[i];
            base.RemoveItem(i);
            OnItemRemoved(this, new ItemRemovedEventArgs(i, item));
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
                Insert(newItem);
            }
        }

        public void Insert(InventoryItem newItem)
        {
            var combined = false;

            // Go through all existing items
            for (int i = 0; i < Count; i++)
            {
                var oldItem = this[i];

                // Equality based on ITEMID and COLOR combined
                if (oldItem.ItemId == newItem.ItemId && oldItem.Color == newItem.Color)
                {
                    // New item already in list! Combine old and new one to make the updated item
                    var itemsCombined = oldItem + newItem;
                    SetItem(i, itemsCombined);

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
        }
    }
}
