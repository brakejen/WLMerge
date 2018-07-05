using System;
using System.IO;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WLMerge
{
    /// <summary>
    /// Represents a Wanted List for Bricklink. The class Inventory is a direct mapping to the XML-structure of Wanted Lists.
    /// The class is XML-serializable, ie can read and export Wanted List XML.
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "INVENTORY" )]
    public class Inventory
    {
        /// <summary>
        /// Each element represent a unique property of an InventoryItem.
        /// Maps each property to a unique int 0-10.
        /// </summary>
        public enum ItemProperty
        {
            ITEMTYPE = 0,
            ITEMID = 1,
            COLOR = 2,
            MAXPRICE = 3,
            MINQTY = 4,
            QTYFILLED = 5,
            CONDITION = 6,
            REMARKS = 7,
            NOTIFY = 8,
            WANTEDSHOW = 9,
            WANTEDLISTID = 10,
        }

        /// <summary>
        /// Write this Inventory to a string representing the XML-cod for it. 
        /// </summary>
        public string ToXml()
        {
            using (StringWriter textWriter = new StringWriter())
            {
                new XmlSerializer(typeof(Inventory)).Serialize(textWriter, this);
                return textWriter.ToString();
            }
        }

        /// <summary>
        /// Load Inventory from an XML-file. 
        /// </summary>
        /// <param name="path">Full path to the file, including filename</param>
        /// <returns>New Inventory with items from XML file in it</returns>
        public static Inventory FromXmlFile(string path)
        {
            string xmlDocumentText = File.ReadAllText(path);
            XmlSerializer serializer = new XmlSerializer(typeof(Inventory));
            using (StringReader reader = new StringReader(xmlDocumentText))
            {
                Inventory inventory = (Inventory)(serializer.Deserialize(reader));
                return inventory;
            }
        }

        private InventoryItem[] _items;

        /// <summary>
        /// The list of Inventory Items in this Inventory
        /// </summary>
        [XmlElement("ITEM")]
        public InventoryItem[] Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
    }

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class InventoryItem
    {
        private string _itemType;

        private string _itemId;

        private int _color;

        private decimal _maxPrice;

        private int _minQty;

        private int _qtyFilled;

        private string _condition;

        private string _remarks;

        private string _notify;

        private string _wantedShow;

        private string _wantedListId;

        [XmlElement("ITEMTYPE")]
        public string ItemType
        {
            get
            {
                return this._itemType;
            }
            set
            {
                this._itemType = value;
            }
        }

        [XmlElement("ITEMID")]
        public string ItemId
        {
            get
            {
                return this._itemId;
            }
            set
            {
                this._itemId = value;
            }
        }

        [XmlElement("COLOR")]
        public int Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        [XmlElement("MAXPRICE")]
        public decimal MaxPrice
        {
            get
            {
                return this._maxPrice;
            }
            set
            {
                this._maxPrice = value;
            }
        }

        [XmlElement("MINQTY")]
        public int MinQty
        {
            get
            {
                return this._minQty;
            }
            set
            {
                this._minQty = value;
            }
        }


        [XmlElement("QTYFILLED")]
        public int QtyFilled
        {
            get
            {
                return this._qtyFilled;
            }
            set
            {
                this._qtyFilled = value;
            }
        }

        [XmlElement("COMDITION")]
        public string Condition
        {
            get
            {
                return this._condition;
            }
            set
            {
                this._condition = value;
            }
        }

        [XmlElement("REMARKS")]
        public string Remarks
        {
            get
            {
                return this._remarks;
            }
            set
            {
                this._remarks = value;
            }
        }

        [XmlElement("NOTIFY")]
        public string Notify
        {
            get
            {
                return this._notify;
            }
            set
            {
                this._notify = value;
            }
        }

        [XmlElement("WANTEDSHOW")]
        public string WantedShow
        {
            get
            {
                return this._wantedShow;
            }
            set
            {
                this._wantedShow = value;
            }
        }

        [XmlElement("WANTEDLISTID")]
        public string WantedListId
        {
            get
            {
                return this._wantedListId;
            }
            set
            {
                this._wantedListId = value;
            }
        }

        public static Type ItemPropertyType(Inventory.ItemProperty itemProperty)
        {
            switch (itemProperty)
            {
                case Inventory.ItemProperty.ITEMTYPE:
                case Inventory.ItemProperty.ITEMID:
                case Inventory.ItemProperty.CONDITION:
                case Inventory.ItemProperty.REMARKS:
                case Inventory.ItemProperty.NOTIFY:
                case Inventory.ItemProperty.WANTEDSHOW:
                case Inventory.ItemProperty.WANTEDLISTID:
                    return typeof(string);
                case Inventory.ItemProperty.COLOR:
                case Inventory.ItemProperty.MINQTY:
                case Inventory.ItemProperty.QTYFILLED:
                    return typeof(int);
                case Inventory.ItemProperty.MAXPRICE:
                    return  typeof(decimal);
                default:
                    throw new ArgumentException("ItemPropertyType");
             }
        }

        /// <summary>
        /// Combine two Inventory Items into one new. 
        /// Rules used:
        ///     1. ItemType, ItemId and Color needs to be the same, otherwise they´re not possible to combine to a valid new one
        ///     2. MaxPrice is the largest of the two items (perhaps it should be the smallest?)
        ///     3. MinQty and QtyFilled is the sum of the two items, respectively 
        ///     4. Remarks are concatenated with i1 first and i2 second and separator in between (two vertical bars)
        ///     5. Rest of the properties are taken from i2 (i1 overwritten regardsless of value)
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
        public static InventoryItem operator +(InventoryItem i1, InventoryItem i2)
        {
            if(i1.ItemType.ToUpper() != i2.ItemType.ToUpper())
            {
                throw new ArgumentException($"Cannot add two Inventory Items with different types: '{i1.ItemType}' != '{i2.ItemType}'");
            }

            if (i1.ItemId.ToUpper() != i2.ItemId.ToUpper())
            {
                throw new ArgumentException($"Cannot add two Inventory Items with different id's: '{i1.ItemId}' != '{i2.ItemId}'");
            }

            if (i1.Color != i2.Color)
            {
                throw new ArgumentException($"Cannot add two Inventory Items with different colors: '{i1.Color}' != '{i2.Color}'");
            }

            var itemsCombined = new InventoryItem
            {
                ItemType = i2.ItemType,
                ItemId = i2.ItemId,
                Color = i2.Color,
                MaxPrice = Math.Max(i1.MaxPrice, i2.MaxPrice),
                MinQty = i1.MinQty + i2.MinQty,
                QtyFilled = i1.QtyFilled + i2.QtyFilled,
                Condition = i2.Condition,
                Remarks = $"{i1.Remarks} || {i2.Remarks}",
                Notify = i2.Notify,
                WantedShow = i2.WantedShow,
                WantedListId = i2.WantedListId,
            };

            return itemsCombined;
        }
    }
}


