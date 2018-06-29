using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WLMerge
{    
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "INVENTORY" )]
    public partial class Inventory
    {
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
        /// Write this INVENTORY to a string. 
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
        /// Load INVENTORY from XML-file. If multiplier is larger than 1 each item count
        /// will be multiplied with this amount when creating the inventory.
        /// </summary>
        /// <param name="path">Full path to the file, including filename</param>
        /// <param name="multiplier"></param>
        /// <returns>New INVENTORY with items from XML file in it</returns>
        public static Inventory FromXmlFile(string path, int multiplier)
        {
            var d = XDocument.Load(path);

            var items = d.Root.Elements("ITEM")
                .Select(x => new InventoryItem
                {
                    ItemType = x.Element("ITEMTYPE").Value,
                    ItemId = x.Element("ITEMID").Value,
                    Color = int.Parse(x.Element("COLOR").Value),
                    MinQty = int.Parse(x.Element("MINQTY").Value) * (multiplier > 0 ? multiplier : 1),
                    Notify = x.Element("NOTIFY").Value,
                    Remarks = x.Element("REMARKS") == null ? "" : x.Element("REMARKS").Value,
                });

            var inventory = new Inventory()
            {
                Item = items.ToArray()
            };

            return inventory;
        }

        private InventoryItem[] _item;

        /// <remarks/>
        [XmlElement("ITEM")]
        public InventoryItem[] Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class InventoryItem
    {

        private string _itemId;

        private int _color;

        private int _minQty;

        private string _itemType;

        private string _notify;

        private string _remarks;

        /// <remarks/>
        /// <remarks/>
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

        /// <remarks/>
        /// 
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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
    }
}


