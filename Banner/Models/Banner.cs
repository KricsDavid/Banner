using System;
using System.Drawing;

namespace Banner.Models
{
    public class Banner : ABanner, IBannerOperations
    {
        public Banner(int rowNum, int columnNum) : base(rowNum, columnNum)
        {
        }

        public void Clear()
        {
            
            for (int i = 0; i < RowNum; i++)
            {
                for (int j = 0; j < ColumnNum; j++)
                {
                    this[i, j] = Color.Black; 
                }
            }
        }

        public void DrawLine(int rowIndex, Color drawingColor)
        {
            if (rowIndex < 0 || rowIndex >= RowNum)
            {
                throw new ArgumentOutOfRangeException(nameof(rowIndex), "Nem jó");
            }

            for (int j = 0; j < ColumnNum; j++)
            {
                this[rowIndex, j] = drawingColor;
            }
        }

        public void RotateToLeft()
        {
            Color[,] newPixels = new Color[ColumnNum, RowNum];
            for (int i = 0; i < RowNum; i++)
            {
                for (int j = 0; j < ColumnNum; j++)
                {
                    newPixels[ColumnNum - j - 1, i] = this[i, j]; 
                }
            }
           
        }

        public void RotateToRight()
        {
            Color[,] newPixels = new Color[ColumnNum, RowNum];
            for (int i = 0; i < RowNum; i++)
            {
                for (int j = 0; j < ColumnNum; j++)
                {
                    newPixels[j, RowNum - i - 1] = this[i, j]; 
                }
            }
            
        }

        public void ShiftToLeft(Color fillColor)
        {
            for (int i = 0; i < RowNum; i++)
            {
                for (int j = 0; j < ColumnNum - 1; j++)
                {
                    this[i, j] = this[i, j + 1]; 
                }
                this[i, ColumnNum - 1] = fillColor; 
            }
        }

        public void ShiftToRight(Color fillColor)
        {
            for (int i = 0; i < RowNum; i++)
            {
                for (int j = ColumnNum - 1; j > 0; j--)
                {
                    this[i, j] = this[i, j - 1]; 
                }
                this[i, 0] = fillColor; 
            }
        }
    }
}
}
