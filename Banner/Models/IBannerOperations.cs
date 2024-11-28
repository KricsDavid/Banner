using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banner.Models
{
    internal interface IBannerOperations
    {
        /// <summary>
        /// Feketére színezi a teljes kijelzőt.
        /// </summary>
        public void Clear();

        /// <summary>
        /// Egy pixellel balra forgatja a képet
        /// </summary>
        public void RotateToLeft();

        public void RotateToRight();


        /// <summary>
        /// Egy pixellel balra tolja a képet
        /// </summary>
        public void ShiftToLeft(Color fillColor);

        public void ShiftToRight(Color fillColor);

        public void DrawLine(int rowIndex, Color drawingColor);

    }
}
