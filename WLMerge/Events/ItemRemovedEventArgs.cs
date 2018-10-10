using System;

namespace WLMerge
{
    public class ItemRemovedEventArgs : EventArgs
    {
        int _index;
        private InventoryItem _oldItem;

        public ItemRemovedEventArgs(int index, InventoryItem oldItem)
        {
            _index = index;
            _oldItem = oldItem;
        }

        public int Index { get { return _index; } }
        public InventoryItem OldItem { get { return _oldItem; } }
    }
}
