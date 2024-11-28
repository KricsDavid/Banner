using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banner.Models
{
    public abstract class ABanner
    {
        const int MAX_ROWNUM = 30;
        const int MAX_COLUMNNUM = 1000;
        const int MIN_ROWNUM = 8;
        const int MIN_COLUMNNUM = 20;

        private Color[,] pixel;

        protected ABanner(int rowNum, int columnNum)
        {
            if (rowNum < MIN_ROWNUM || rowNum > MAX_ROWNUM
                || columnNum > MAX_COLUMNNUM || columnNum < MIN_COLUMNNUM)
                throw new ArgumentException("Nem megengedett argumentum!");

            pixel = new Color[rowNum, columnNum];  
        }
        protected ABanner() : this(MIN_ROWNUM, MIN_COLUMNNUM)
        {
        }

        public int RowNum => pixel.GetLength(0);
        public int ColumnNum => pixel.GetLength(1);

        //public Color[,] Pixel => pixel;  //Property használatával

        public Color this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex < MIN_ROWNUM || rowIndex > MAX_ROWNUM
                    || colIndex > MAX_COLUMNNUM || colIndex < MIN_ROWNUM)
                    throw new ArgumentException("Nem megengedett argumentum!");
                return pixel[rowIndex, colIndex];
            }
            set
            {
                if (rowIndex < MIN_ROWNUM || rowIndex > MAX_ROWNUM
                    || colIndex > MAX_COLUMNNUM || colIndex < MIN_ROWNUM)
                    throw new ArgumentException("Nem megengedett argumentum!");
                pixel[rowIndex, colIndex]=value;
            }

        }

    }
}
