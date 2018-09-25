using System;
using System.Drawing;

namespace WLMerge
{
    /// <summary>
    /// Represents color information of a Bricklink Color
    /// Information of colors include:
    ///     - The Bricklink id of the color
    ///     - The Bricklink name (description) of the color
    ///     - A derived background color matching the LEGO color of the Bricklink color id, represented as a 6 digit string
    ///     - A derived 'matching' foreground color that has good contrast to the background color, repsented as a 6 digit string
    /// </summary>
    public struct BricklinkColorInfo
    {
        public int Id;
        public string Bg;
        public string Fg;
        public string Name;
    }
    public static class BricklinkColors
    {
        public static Color FromString(string s)
        {
            if (s.Length != 6)
            {
                throw new ArgumentException($"Malformed color code in '{s}': expected 6 charachters, got {s.Length}");
            }

            try
            {
                // Get color components
                var r = Convert.ToInt32(s.Substring(0, 2), 16);
                var g = Convert.ToInt32(s.Substring(2, 2), 16);
                var b = Convert.ToInt32(s.Substring(4, 2), 16);

                // Compose color and return it
                var color = Color.FromArgb(r, g, b);
                return color;
            }
            catch (Exception)
            {
                throw new ArgumentException($"Malformed color code in '{s}': does not represent a valid color");
            }
        }

        /// <summary>
        /// Given a Bricklink Color Id, return the BricklinkColorInfo that this color has.
        /// </summary>
        /// <param name="colorId"></param>
        /// <returns>Information of given color (id)</returns>
        public static BricklinkColorInfo GetInfo(int colorId)
        {
            BricklinkColorInfo cInfo;

            switch (colorId)
            {
                case   1: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFFFFF", Fg = "000000", Name = "White" }; break;
                case   2: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "dec69c", Fg = "000000", Name = "Tan" }; break;
                case   3: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "f7d117", Fg = "000000", Name = "Yellow" }; break;
                case   4: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FF7E14", Fg = "000000", Name = "Orange" }; break;
                case   5: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "b30006", Fg = "FFFFFF", Name = "Red" }; break;
                case   6: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "00642e", Fg = "FFFFFF", Name = "Green" }; break;
                case   7: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "0057a6", Fg = "FFFFFF", Name = "Blue" }; break;
                case   8: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "532115", Fg = "FFFFFF", Name = "Brown" }; break;
                case   9: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "9c9c9c", Fg = "000000", Name = "Light Gray" }; break;
                case  10: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "6b5a5a", Fg = "FFFFFF", Name = "Dark Gray" }; break;
                case  11: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "212121", Fg = "FFFFFF", Name = "Black" }; break;
                case  12: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "EEEEEE", Fg = "000000", Name = "Trans-Clear" }; break;
                case  13: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "939484", Fg = "000000", Name = "Trans-Black" }; break;
                case  14: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "00296B", Fg = "FFFFFF", Name = "Trans-Dark Blue" }; break;
                case  15: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "68BCC5", Fg = "000000", Name = "Trans-Light Blue" }; break;
                case  16: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "C0F500", Fg = "000000", Name = "Trans-Neon Green" }; break;
                case  17: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "9C0010", Fg = "FFFFFF", Name = "Trans-Red" }; break;
                case  18: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FF4231", Fg = "FFFFFF", Name = "Trans-Neon Orange" }; break;
                case  19: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "EBF72D", Fg = "000000", Name = "Trans-Yellow" }; break;
                case  20: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "217625", Fg = "FFFFFF", Name = "Trans-Green" }; break;
                case  21: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "f1f2e1", Fg = "000000", Name = "Chrome Gold" }; break;
                case  22: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "DCDCDC", Fg = "000000", Name = "Chrome Silver" }; break;
                case  23: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFC0CB", Fg = "000000", Name = "Pink" }; break;
                case  24: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "a5499c", Fg = "FFFFFF", Name = "Purple" }; break;
                case  25: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "f45c40", Fg = "000000", Name = "Salmon" }; break;
                case  26: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFDEDC", Fg = "000000", Name = "Light Salmon" }; break;
                case  27: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "b52c20", Fg = "FFFFFF", Name = "Rust" }; break;
                case  28: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "CC8062", Fg = "000000", Name = "Flesh" }; break;
                case  29: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "E6881D", Fg = "000000", Name = "Earth Orange" }; break;
                case  31: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFA531", Fg = "000000", Name = "Medium Orange" }; break;
                case  32: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "f7ad63", Fg = "000000", Name = "Light Orange" }; break;
                case  33: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "ffe383", Fg = "000000", Name = "Light Yellow" }; break;
                case  34: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "A6CA55", Fg = "000000", Name = "Lime" }; break;
                case  35: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "EbEE8F", Fg = "000000", Name = "Light Lime" }; break;
                case  36: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "10cb31", Fg = "000000", Name = "Bright Green" }; break;
                case  37: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "62F58E", Fg = "000000", Name = "Medium Green" }; break;
                case  38: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "a5dbb5", Fg = "000000", Name = "Light Green" }; break;
                case  39: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "008a80", Fg = "FFFFFF", Name = "Dark Turquoise" }; break;
                case  40: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "31B5CA", Fg = "000000", Name = "Light Turquoise" }; break;
                case  41: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "b5d3d6", Fg = "000000", Name = "Aqua" }; break;
                case  42: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "61afff", Fg = "000000", Name = "Medium Blue" }; break;
                case  43: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "3448a4", Fg = "FFFFFF", Name = "Violet" }; break;
                case  44: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "C9CAE2", Fg = "000000", Name = "Light Violet" }; break;
                case  46: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "d4d5c9", Fg = "000000", Name = "Glow In Dark Opaque" }; break;
                case  47: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "C87080", Fg = "000000", Name = "Dark Pink" }; break;
                case  48: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "76a290", Fg = "000000", Name = "Sand Green" }; break;
                case  49: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "E8E8E8", Fg = "000000", Name = "Very Light Gray" }; break;
                case  50: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "CE1d9b", Fg = "FFFFFF", Name = "Trans-Dark Pink" }; break;
                case  51: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "8320B7", Fg = "FFFFFF", Name = "Trans-Purple" }; break;
                case  52: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "5C66A4", Fg = "FFFFFF", Name = "Chrome Blue" }; break;
                case  54: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "B57DA5", Fg = "000000", Name = "Sand Purple" }; break;
                case  55: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "5a7184", Fg = "FFFFFF", Name = "Sand Blue" }; break;
                case  56: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFE1FF", Fg = "000000", Name = "Light Pink" }; break;
                case  57: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "645a4c", Fg = "FFFFFF", Name = "Chrome Antique Brass" }; break;
                case  58: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "8c6b6b", Fg = "FFFFFF", Name = "Sand Red" }; break;
                case  59: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "6a0e15", Fg = "FFFFFF", Name = "Dark Red" }; break;
                case  60: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "d4d3dd", Fg = "000000", Name = "Milky White" }; break;
                case  61: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "E7AE5A", Fg = "000000", Name = "Pearl Light Gold" }; break;
                case  62: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "B4D2E3", Fg = "000000", Name = "Light Blue" }; break;
                case  63: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "143044", Fg = "FFFFFF", Name = "Dark Blue" }; break;
                case  64: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "3CB371", Fg = "000000", Name = "Chrome Green" }; break;
                case  65: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "B8860B", Fg = "000000", Name = "Metallic Gold" }; break;
                case  66: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "ACB7C0", Fg = "000000", Name = "Pearl Light Gray" }; break;
                case  67: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "C0C0C0", Fg = "000000", Name = "Metallic Silver" }; break;
                case  68: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "b35408", Fg = "FFFFFF", Name = "Dark Orange" }; break;
                case  69: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "907450", Fg = "FFFFFF", Name = "Dark Tan" }; break;
                case  70: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "bdb573", Fg = "000000", Name = "Metallic Green" }; break;
                case  71: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "B52952", Fg = "FFFFFF", Name = "Magenta" }; break;
                case  72: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "6BADD6", Fg = "000000", Name = "Maersk Blue" }; break;
                case  73: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "939100", Fg = "000000", Name = "Medium Violet" }; break;
                case  74: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "7384A5", Fg = "000000", Name = "Trans-Medium Blue" }; break;
                case  76: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "BDC618", Fg = "000000", Name = "Medium Lime" }; break;
                case  77: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "666660", Fg = "FFFFFF", Name = "Pearl Dark Gray" }; break;
                case  78: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "5686AE", Fg = "FFFFFF", Name = "Metal Blue" }; break;
                case  80: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "2E5543", Fg = "FFFFFF", Name = "Dark Green" }; break;
                case  81: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "AD7118", Fg = "FFFFFF", Name = "Flat Dark Gold" }; break;
                case  82: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "aa4d8e", Fg = "FFFFFF", Name = "Chrome Pink" }; break;
                case  83: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFFFFF", Fg = "000000", Name = "Pearl White" }; break;
                case  84: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "C66921", Fg = "FFFFFF", Name = "Copper" }; break;
                case  85: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "595D60", Fg = "FFFFFF", Name = "Dark Bluish Gray" }; break;
                case  86: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "afb5c7", Fg = "000000", Name = "Light Bluish Gray" }; break;
                case  87: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "7DBFDD", Fg = "000000", Name = "Sky Blue" }; break;
                case  88: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "89351d", Fg = "FFFFFF", Name = "Reddish Brown" }; break;
                case  89: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "5f2683", Fg = "FFFFFF", Name = "Dark Purple" }; break;
                case  90: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "feccb0", Fg = "000000", Name = "Light Flesh" }; break;
                case  91: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "774125", Fg = "FFFFFF", Name = "Dark Flesh" }; break;
                case  93: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "DA70D6", Fg = "000000", Name = "Light Purple" }; break;
                case  94: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "F785B1", Fg = "000000", Name = "Medium Dark Pink" }; break;
                case  95: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "8D949C", Fg = "000000", Name = "Flat Silver" }; break;
                case  96: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "E6C05D", Fg = "000000", Name = "Very Light Orange" }; break;
                case  97: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "506cef", Fg = "FFFFFF", Name = "Blue-Violet" }; break;
                case  98: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "D04010", Fg = "FFFFFF", Name = "Trans-Orange" }; break;
                case  99: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "e4e8e8", Fg = "000000", Name = "Very Light Bluish Gray" }; break;
                case 100: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "ab43c3", Fg = "FFFFFF", Name = "Glitter Trans-Dark Pink" }; break;
                case 101: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "b2adaa", Fg = "000000", Name = "Glitter Trans-Clear" }; break;
                case 102: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "3A2B82", Fg = "FFFFFF", Name = "Glitter Trans-Purple" }; break;
                case 103: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "F3E055", Fg = "000000", Name = "Bright Light Yellow" }; break;
                case 104: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFBBFF", Fg = "000000", Name = "Bright Pink" }; break;
                case 105: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "9FC3E9", Fg = "000000", Name = "Bright Light Blue" }; break;
                case 106: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "B3694E", Fg = "FFFFFF", Name = "Fabuland Brown" }; break;
                case 107: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FF8298", Fg = "000000", Name = "Trans-Pink" }; break;
                case 108: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "10Cb31", Fg = "000000", Name = "Trans-Bright Green" }; break;
                case 109: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "2032B0", Fg = "FFFFFF", Name = "Dark Blue-Violet" }; break;
                case 110: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "F7BA30", Fg = "000000", Name = "Bright Light Orange" }; break;
                case 111: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "7C7E7C", Fg = "FFFFFF", Name = "Speckle Black-Silver" }; break;
                case 113: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "B7C8BF", Fg = "000000", Name = "Trans-Very Lt Blue" }; break;
                case 114: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "B97AB1", Fg = "000000", Name = "Trans-Light Purple" }; break;
                case 115: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "E79500", Fg = "000000", Name = "Pearl Gold" }; break;
                case 116: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "5F4E47", Fg = "FFFFFF", Name = "Speckle Black-Copper" }; break;
                case 117: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "4A6363", Fg = "FFFFFF", Name = "Speckle DBGray-Silver" }; break;
                case 118: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "bdc6ad", Fg = "000000", Name = "Glow In Dark Trans" }; break;
                case 119: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "D4D2CD", Fg = "000000", Name = "Pearl Very Light Gray" }; break;
                case 120: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "330000", Fg = "FFFFFF", Name = "Dark Brown" }; break;
                case 121: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFD700", Fg = "000000", Name = "Trans-Neon Yellow" }; break;
                case 122: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "544E4F", Fg = "FFFFFF", Name = "Chrome Black" }; break;
                case 123: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFFFFF", Fg = "000000", Name = "Mx White" }; break;
                case 124: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "AfB5C7", Fg = "000000", Name = "Mx Light Bluish Gray" }; break;
                case 125: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "9C9C9C", Fg = "000000", Name = "Mx Light Gray" }; break;
                case 126: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "595D60", Fg = "FFFFFF", Name = "Mx Charcoal Gray" }; break;
                case 127: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "6B5A5A", Fg = "FFFFFF", Name = "Mx Tile Gray" }; break;
                case 128: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "000000", Fg = "FFFFFF", Name = "Mx Black" }; break;
                case 129: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "B52C20", Fg = "FFFFFF", Name = "Mx Red" }; break;
                case 130: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "F45C40", Fg = "000000", Name = "Mx Pink Red" }; break;
                case 131: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "330000", Fg = "FFFFFF", Name = "Mx Tile Brown" }; break;
                case 132: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "907450", Fg = "FFFFFF", Name = "Mx Brown" }; break;
                case 133: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "DEC69C", Fg = "000000", Name = "Mx Buff" }; break;
                case 134: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "5C5030", Fg = "FFFFFF", Name = "Mx Terracotta" }; break;
                case 135: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "F47B30", Fg = "000000", Name = "Mx Orange" }; break;
                case 136: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "F7AD63", Fg = "000000", Name = "Mx Light Orange" }; break;
                case 137: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFE371", Fg = "000000", Name = "Mx Light Yellow" }; break;
                case 138: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FED557", Fg = "000000", Name = "Mx Ochre Yellow" }; break;
                case 139: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "BDC618", Fg = "000000", Name = "Mx Lemon" }; break;
                case 140: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "7C9051", Fg = "000000", Name = "Mx Olive Green" }; break;
                case 141: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "7DB538", Fg = "000000", Name = "Mx Pastel Green" }; break;
                case 142: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "27867E", Fg = "FFFFFF", Name = "Mx Aqua Green" }; break;
                case 143: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "0057A6", Fg = "FFFFFF", Name = "Mx Tile Blue" }; break;
                case 144: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "61AFFF", Fg = "000000", Name = "Mx Medium Blue" }; break;
                case 145: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "68AECE", Fg = "000000", Name = "Mx Pastel Blue" }; break;
                case 146: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "467083", Fg = "FFFFFF", Name = "Mx Teal Blue" }; break;
                case 147: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "BD7D85", Fg = "000000", Name = "Mx Violet" }; break;
                case 148: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "F785B1", Fg = "000000", Name = "Mx Pink" }; break;
                case 149: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFFFFF", Fg = "000000", Name = "Mx Clear" }; break;
                case 150: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "E78B3E", Fg = "000000", Name = "Medium Dark Flesh" }; break;
                case 151: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "AB9421", Fg = "000000", Name = "Speckle Black-Gold" }; break;
                case 152: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "CCFFFF", Fg = "000000", Name = "Light Aqua" }; break;
                case 153: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "3399FF", Fg = "000000", Name = "Dark Azure" }; break;
                case 154: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "B18CBF", Fg = "000000", Name = "Lavender" }; break;
                case 155: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "7C9051", Fg = "000000", Name = "Olive Green" }; break;
                case 156: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "42C0FB", Fg = "000000", Name = "Medium Azure" }; break;
                case 157: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "885E9E", Fg = "FFFFFF", Name = "Medium Lavender" }; break;
                case 158: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "DFEEA5", Fg = "000000", Name = "Yellowish Green" }; break;
                case 159: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "d9d9d9", Fg = "000000", Name = "Glow In Dark White" }; break;
                case 160: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "EF9121", Fg = "000000", Name = "Fabuland Orange" }; break;
                case 161: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "DD982E", Fg = "000000", Name = "Dark Yellow" }; break;
                case 162: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "68BCC5", Fg = "000000", Name = "Glitter Trans-Light Blue" }; break;
                case 163: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "C0F500", Fg = "000000", Name = "Glitter Trans-Neon Green" }; break;
                case 164: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "E99A3A", Fg = "000000", Name = "Trans-Light Orange" }; break;
                case 165: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FA5947", Fg = "000000", Name = "Neon Orange" }; break;
                case 166: cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "BCEF66", Fg = "000000", Name = "Neon Green" }; break;
                default:  cInfo = new BricklinkColorInfo() { Id = colorId, Bg = "FFFFFF", Fg = "000000", Name = "???" }; break;
            }

            return cInfo;
        }
    }

    
}
