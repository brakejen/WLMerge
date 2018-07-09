using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLMerge
{
    public static class ValueValidator
    {
        /// <summary>
        /// Validate value 'x' against property 'property'
        /// </summary>
        /// <param name="x"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string Validate(string text, InventoryItem.ItemProperty property)
        {
            var targetType = InventoryItem.ItemPropertyType(property); ;
            decimal lowerBound = 0; // Todo: possibly change this according to rules 
            // (BL seem to accept -1 in some properties, what does that mean?
            // https://www.bricklink.com/help.asp?helpID=207 nothing here about -1....)

            if (targetType == typeof(int))
            {
                try
                {
                    int x = int.Parse(text);
                    
                    return x >= lowerBound ? string.Empty : $"Must be {(int)lowerBound} or greater";
                }
                catch //(Exception ex)
                {
                    return "Not an integer value";
                }
            }
            else if (targetType == typeof(decimal))
            {
                try
                {
                    decimal x = decimal.Parse(text);
                    return x >= lowerBound ? string.Empty : $"Must be {lowerBound} or greater";
                }
                catch //(Exception ex)
                {
                    return "Not a decimal value.";
                }
            }

            return string.Empty;
        }

    }
}

