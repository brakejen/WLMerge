using System;

namespace WLMerge
{
    public class ItemAddedEventArgs : EventArgs
    {
        int _index;
        private InventoryItem _newItem;

        public ItemAddedEventArgs(int index, InventoryItem newItem)
        {
            _index = index;
            _newItem = newItem;
        }

        public int Index { get { return _index; } }
        public InventoryItem NewItem { get { return _newItem; } }
    }
}
