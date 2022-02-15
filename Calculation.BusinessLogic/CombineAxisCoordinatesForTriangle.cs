using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation.BusinessLogic
{
    public class CombineAxisCoordinatesForTriangle : CombineCoordinates
    {
        public Coordinates LeftCoordinates { get; set; }

        public Coordinates AngleCoordinates { get; set; }

        public Coordinates RightCoordinates { get; set; }

        public CombineAxisCoordinatesForTriangle AddLeftCoordinates(Coordinates leftCoordinates)
        {
            this.LeftCoordinates = leftCoordinates;
            this.CoordinatesList.Add(LeftCoordinates);
            return this;
        }

        public CombineAxisCoordinatesForTriangle AddAngleCoordinates(Coordinates angleCoordinates)
        {
            this.AngleCoordinates = angleCoordinates;
            this.CoordinatesList.Add(AngleCoordinates);
            return this;
        }

        public CombineAxisCoordinatesForTriangle AddRightCoordinates(Coordinates rightCoordinates)
        {
            this.RightCoordinates = rightCoordinates;
            this.CoordinatesList.Add(RightCoordinates);
            return this;
        }
    }
}
