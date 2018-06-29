using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WLMerge
{
    
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class INVENTORY
    {
        /// <summary>
        /// Write this INVENTORY to a string. 
        /// </summary>
        public string ToXml()
        {
            using (StringWriter textWriter = new StringWriter())
            {
                new XmlSerializer(typeof(INVENTORY)).Serialize(textWriter, this);
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
        public static INVENTORY FromXmlFile(string path, int multiplier)
        {
            var d = XDocument.Load(path);

            var items = d.Root.Elements("ITEM")
                .Select(x => new INVENTORYITEM
                {
                    ITEMTYPE = x.Element("ITEMTYPE").Value,
                    ITEMID = x.Element("ITEMID").Value,
                    COLOR = int.Parse(x.Element("COLOR").Value),
                    MINQTY = int.Parse(x.Element("MINQTY").Value) * (multiplier > 0 ? multiplier : 1),
                    NOTIFY = x.Element("NOTIFY").Value,
                    REMARKS = x.Element("REMARKS") == null ? "" : x.Element("REMARKS").Value,
                });

            var inventory = new INVENTORY()
            {
                ITEM = items.ToArray<INVENTORYITEM>()
            };

            return inventory;
        }

        private INVENTORYITEM[] iTEMField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ITEM")]
        public INVENTORYITEM[] ITEM
        {
            get
            {
                return this.iTEMField;
            }
            set
            {
                this.iTEMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class INVENTORYITEM
    {

        private string iTEMIDField;

        private int cOLORField;

        private int mINQTYField;

        private string iTEMTYPEField;

        private string nOTIFYField;

        private string rEMARKSField;

        /// <remarks/>
        /// <remarks/>
        public string ITEMID
        {
            get
            {
                return this.iTEMIDField;
            }
            set
            {
                this.iTEMIDField = value;
            }
        }

        /// <remarks/>
        public int COLOR
        {
            get
            {
                return this.cOLORField;
            }
            set
            {
                this.cOLORField = value;
            }
        }

        /// <remarks/>
        public int MINQTY
        {
            get
            {
                return this.mINQTYField;
            }
            set
            {
                this.mINQTYField = value;
            }
        }

        public string ITEMTYPE
        {
            get
            {
                return this.iTEMTYPEField;
            }
            set
            {
                this.iTEMTYPEField = value;
            }
        }

        /// <remarks/>
        public string NOTIFY
        {
            get
            {
                return this.nOTIFYField;
            }
            set
            {
                this.nOTIFYField = value;
            }
        }

        /// <remarks/>
        public string REMARKS
        {
            get
            {
                return this.rEMARKSField;
            }
            set
            {
                this.rEMARKSField = value;
            }
        }
    }
}


