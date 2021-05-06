using System;
using System.Collections.Generic;
using System.Text;
using WpfMath;
using System.IO;

namespace E_Maths_Learning
{
    public static class ImageGenerator
    {
        private static string[] cars = { "Algebra", "", "", "" };

        public static void GenerateEquations()
        {
            string latex = @"\colorbox[ARGB]{0, 255,255,255}{\color{white}{y-y_1=m(x-x_1)}}";
            string fileName = @"Images\formula.png";

            var parser = new TexFormulaParser();
            var formula = parser.Parse(latex);
            var pngBytes = formula.RenderToPng(50.0, 0.0, 0.0, "Arial");
            File.WriteAllBytes(fileName, pngBytes);
        }
    }
}
