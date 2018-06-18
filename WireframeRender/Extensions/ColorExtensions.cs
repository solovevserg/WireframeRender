using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WireframeRender.Extensions
{
    static class ColorExtensions
    {
        public static Color Color(this Random random)
        {
            Color result = System.Drawing.Color.Black;
            Random generator = new Random();
            int index = generator.Next() % 10;
            switch (index)
            {
                case 0:
                    result = System.Drawing.Color.DeepSkyBlue;
                    break;
                case 1:
                    result = System.Drawing.Color.DarkOrange;
                    break;
                case 2:
                    result = System.Drawing.Color.Coral;
                    break;
                case 3:
                    result = System.Drawing.Color.MediumTurquoise;
                    break;
                case 4:
                    result = System.Drawing.Color.YellowGreen;
                    break;
                case 5:
                    result = System.Drawing.Color.LightGreen;
                    break;
                case 6:
                    result = System.Drawing.Color.MediumVioletRed;
                    break;
                case 7:
                    result = System.Drawing.Color.AntiqueWhite;
                    break;
                case 8:
                    result = System.Drawing.Color.Violet;
                    break;
                case 9:
                    result = System.Drawing.Color.Gold;
                    break;
                default:

                    break;
            }
            return result;
        }
    }
}
