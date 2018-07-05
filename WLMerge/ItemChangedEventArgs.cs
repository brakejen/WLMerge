using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLMerge
{
    public class ItemChangedEventArgs : EventArgs
    {
        int _index;
        private InventoryItem _oldItem;
        private InventoryItem _newItem;

        public ItemChangedEventArgs(int index, InventoryItem oldItem, InventoryItem newItem)
        {
            _index = index;
            _oldItem = oldItem;
            _newItem = newItem;
        }

        public int Index { get { return _index; } }
        public InventoryItem OldItem { get { return _oldItem; } }
        public InventoryItem NewItem { get { return _newItem; } }
    }
}
