using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.IO;
using System.Text.RegularExpressions;

namespace E_Maths_Learning
{
    public static class AppStyle
    {
        public static void defineStyleCode()
        {
            for (int i = 0; i < files.Length; i++)
            {
                if (File.Exists("CSS_Styles\\" + files[i]) == false)
                {
                    styleCode = i;
                    currentStyle = files[i];
                }
            }
        }

        private static int styleCode;
        private static string currentStyle;
        private static string[] files = { "StyleDefault.css", "StyleDyslexic.css", "StyleHighContrast.css" };

        private static SolidColorBrush[] backgroundColours = { new SolidColorBrush(Color.FromArgb(255, (byte)255, (byte)128, (byte)0)), new SolidColorBrush(Color.FromArgb(255, (byte)255, (byte)253, (byte)208)), Brushes.Black};
        private static SolidColorBrush[] textColours = { Brushes.Black, Brushes.Black, Brushes.White};
        private static SolidColorBrush[] boxColours = { Brushes.White, new SolidColorBrush(Color.FromArgb(255, (byte)255, (byte)253, (byte)208)), Brushes.Black };
        private static SolidColorBrush[] boxOutlineColours = { Brushes.Black, Brushes.Black, Brushes.White };

        public static void setStyleCode()
        {

        }

        public static int getStyleCode()
        {
            return styleCode;
        }

        public static SolidColorBrush[] getbackgroundColours()
        {
            return backgroundColours;
        }

        public static SolidColorBrush[] getTextColours()
        {
            return textColours;
        }

        public static SolidColorBrush[] getBoxColours()
        {
            return boxColours;
        }

        public static SolidColorBrush[] getBoxOutlineColours()
        {
            return boxOutlineColours;
        }
    }
}
