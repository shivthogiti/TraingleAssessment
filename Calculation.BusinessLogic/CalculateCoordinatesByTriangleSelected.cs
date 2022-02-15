using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation.BusinessLogic
{
    public class CalculateCoordinatesByTriangleSelected
    {
        public CombineCoordinates Calculate(ISelectedTriangleColumnAndRow selectedTriangleDimensions, IImageGridDimensions gridDimensions)
        {
            if (selectedTriangleDimensions.Column % 2 == 0)
            {
                int leftX = (((selectedTriangleDimensions.Column / 2) - 1) * gridDimensions.EachColumnSize);
                int leftY = (selectedTriangleDimensions.Row - 64) * gridDimensions.EachColumnSize;
                int DownX = leftX + gridDimensions.EachColumnSize;
                int DownY = leftY - gridDimensions.EachColumnSize;
                int AngleX = DownX;
                int AngleY = leftY;
                Coordinates LeftCoordinates = new Coordinates(leftX, leftY);
                Coordinates AngleCoordinates = new Coordinates(AngleX, AngleY);
                Coordinates RightCoordinates = new Coordinates(DownX, DownY);
                return new CombineCoordinates()
                    .AddCoordinates(LeftCoordinates)
                    .AddCoordinates(AngleCoordinates)
                    .AddCoordinates(RightCoordinates);
            }
            else
            {
                int TopX = ((selectedTriangleDimensions.Column - 1) / 2) * gridDimensions.EachColumnSize;
                int TopY = (selectedTriangleDimensions.Row - 64) * gridDimensions.EachColumnSize;
                int RightX = TopX + gridDimensions.EachColumnSize;
                int RightY = ((selectedTriangleDimensions.Row - 64) - 1) * gridDimensions.EachColumnSize;
                int AngleX = TopX;
                int AngleY = RightY;
                Coordinates LeftCoordinates = new Coordinates(TopX, TopY);
                Coordinates AngleCoordinates = new Coordinates(AngleX, AngleY);
                Coordinates RightCoordinates = new Coordinates(RightX, RightY);
                return new CombineCoordinates()
                    .AddCoordinates(LeftCoordinates)
                    .AddCoordinates(AngleCoordinates)
                    .AddCoordinates(RightCoordinates);
            }
        }
    }
}
