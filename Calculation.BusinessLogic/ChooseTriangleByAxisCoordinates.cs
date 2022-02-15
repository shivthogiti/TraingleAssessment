using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation.BusinessLogic
{
    public class ChooseTriangleByAxisCoordinates
    {
        public ISelectedTriangleColumnAndRow GetTriangle(CombineAxisCoordinatesForTriangle axisCoordinatesForTriangle, IImageGridDimensions gridDimensions)
        {
            int column = 0;
            char rowChar = (Char)(65);
            Coordinates leftCoordinates = axisCoordinatesForTriangle.LeftCoordinates;
            Coordinates angleCoordinates = axisCoordinatesForTriangle.AngleCoordinates;
            Coordinates rightCoordinates = axisCoordinatesForTriangle.RightCoordinates;
            if (leftCoordinates.X == angleCoordinates.X)
            {
                column = ((angleCoordinates.X * 2) / gridDimensions.EachColumnSize) + 1; //need column size;
                int row = leftCoordinates.Y / gridDimensions.EachColumnSize;
                rowChar = (Char)(row + 64);
            }
            if (rightCoordinates.X == angleCoordinates.X)
            {
                column = (rightCoordinates.X / gridDimensions.EachColumnSize) * 2;
                int row = (angleCoordinates.Y / gridDimensions.EachColumnSize);
                rowChar = (Char)(row + 64);
            }

            return new SelectedTriangleColumnAndRow(rowChar, column);
        }
    }
}
