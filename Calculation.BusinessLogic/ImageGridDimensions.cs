using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation.BusinessLogic
{
    public class ImageGridDimensions : IImageGridDimensions
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public int EachColumnSize { get; set; }

        public ImageGridDimensions(int height, int width, int eachColumnSize)
        {
            this.Height = height;
            this.Width = width;
            this.EachColumnSize = eachColumnSize;
        }

    }
}
