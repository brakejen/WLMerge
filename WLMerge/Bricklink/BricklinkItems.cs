using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLMerge
{
    /// <summary>
    /// Represents item information of Bricklink items
    /// </summary>
    public static class BricklinkItems
    {
        /// <summary>
        /// Given an item type (one letter code), return the description of that type
        /// </summary>
        /// <param name="itemType"></param>
        /// <returns>Item type description</returns>
        public static string BricklinkItemTypeDescription(string itemType)
        {
            switch (itemType.ToUpper())
            {
                case "S": return "Set";
                case "P": return "Part";
                case "M": return "Minifig";
                case "B": return "Book";
                case "G": return "Gear";
                case "C": return "Catalog";
                case "I": return "Instruction";
                case "O": return "Original Box";
                case "U": return "Unsorted Lot";
                default: return "<Invalid Item Type>";
            }
        }

        public static string BricklinkItemImageUrl(string itemId, int colorId)
        {
            return $"https://img.bricklink.com/ItemImage/PN/{colorId}/{itemId}.png";
        }

    }
}
