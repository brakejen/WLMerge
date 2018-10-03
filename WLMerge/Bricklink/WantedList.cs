using System;
using System.IO;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;

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
        /// The list of Inventory Items in this Inventory
        /// </summary>
        [XmlElement("ITEM")]
        public InventoryItem[] Items { get; set; }

        /// <summary>
        /// Write this Inventory to a string representing the XML-code for it. 
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
            var xmlDocumentText = File.ReadAllText(path);
            var serializer = new XmlSerializer(typeof(Inventory));

            using (StringReader reader = new StringReader(xmlDocumentText))
            {
                try
                {
                    var inventory = (Inventory)(serializer.Deserialize(reader));
                    return inventory;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }

    /// <summary>
    /// Represents an Inventory Item in a Wanted List. This is the main data carrier in the app, as an Inventory Item
    /// is a row in the main table and represent a row in a Wanted List on Bricklink.
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class InventoryItem 
    {
        /// <summary>
        /// Each element represent a unique property of an InventoryItem.
        /// </summary>
        public enum ItemProperty
        {
            ITEMTYPE,
            ITEMID,
            COLOR,
            MAXPRICE,
            MINQTY,
            QTYFILLED,
            CONDITION,
            REMARKS,
            NOTIFY,
            WANTEDSHOW,
            WANTEDLISTID,
        }

        [XmlIgnore]
        public System.Drawing.Image Image { get; set; }

        [XmlElement("ITEMTYPE")]
        public string ItemType { get; set; }

        [XmlElement("ITEMID")]
        public string ItemId { get; set; }

        [XmlElement("COLOR")]
        public int Color { get; set; }

        [XmlElement("MAXPRICE")]
        public decimal MaxPrice { get; set; }

        [XmlElement("MINQTY")]
        public int MinQty { get; set; }

        [XmlElement("QTYFILLED")]
        public int QtyFilled { get; set; }

        [XmlElement("COMDITION")]
        public string Condition { get; set; }

        [XmlElement("REMARKS")] 
        public string Remarks { get; set; }

        [XmlElement("NOTIFY")]
        public string Notify { get; set; }

        [XmlElement("WANTEDSHOW")]
        public string WantedShow { get; set; }

        [XmlElement("WANTEDLISTID")]
        public string WantedListId { get; set; }

        public static Type ItemPropertyType(ItemProperty itemProperty)
        {
            switch (itemProperty)
            {
                case ItemProperty.ITEMTYPE:
                case ItemProperty.ITEMID:
                case ItemProperty.CONDITION:
                case ItemProperty.REMARKS:
                case ItemProperty.NOTIFY:
                case ItemProperty.WANTEDSHOW:
                case ItemProperty.WANTEDLISTID:
                    return typeof(string);
                case ItemProperty.COLOR:
                case ItemProperty.MINQTY:
                case ItemProperty.QTYFILLED:
                    return typeof(int);
                case ItemProperty.MAXPRICE:
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
                // Same by definition
                ItemType = i2.ItemType,
                ItemId = i2.ItemId,
                Color = i2.Color,

                // Calculated
                MaxPrice = Math.Max(i1.MaxPrice, i2.MaxPrice),
                MinQty = i1.MinQty + i2.MinQty,
                QtyFilled = i1.QtyFilled + i2.QtyFilled,
                Remarks = $"{i1.Remarks} || {i2.Remarks}",

                // i1 overwritten by i2. They could be different but it makes no sense to try to combine them
                Condition = i2.Condition,
                Notify = i2.Notify,
                WantedShow = i2.WantedShow,
                WantedListId = i2.WantedListId,

                // Special for images
                Image = i1.Image ?? i2.Image,
            };

            return itemsCombined;
        }
    }
}


