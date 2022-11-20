using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Schedule_Creator
{
    public static class func
    {


        private static Random randomGen = new Random();
        public static Color GetRandomColor()
        {
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            return randomColor;
        }

        private static KnownColor[] ListaCulori = new KnownColor[]{KnownColor.Lime,KnownColor.LightSlateGray,KnownColor.Gold,KnownColor.Aqua,KnownColor.BurlyWood,KnownColor.Coral,KnownColor.CadetBlue,KnownColor.DarkGray,KnownColor.DarkKhaki,KnownColor.Goldenrod,KnownColor.GreenYellow,KnownColor.LightGreen,KnownColor.LightPink,KnownColor.LightSalmon,KnownColor.LightSkyBlue,KnownColor.LightSeaGreen,KnownColor.LightSteelBlue,KnownColor.LimeGreen,KnownColor.MediumSeaGreen,KnownColor.OliveDrab,KnownColor.MediumSlateBlue,KnownColor.Orange,KnownColor.Orchid,KnownColor.PaleGreen,KnownColor.PaleTurquoise,KnownColor.PowderBlue,KnownColor.RosyBrown,KnownColor.Salmon,KnownColor.SandyBrown,KnownColor.Tan};
        private static int IndexListaCulori = 0;
        public static Color GetColorFromList(){
            if (IndexListaCulori >= ListaCulori.Length) IndexListaCulori = 0;
            return Color.FromKnownColor(ListaCulori[IndexListaCulori++]);
        }

        public static string IntToLetter(int x)
        {
            return ((char)(x + 'A')).ToString();
        }
    }
}
