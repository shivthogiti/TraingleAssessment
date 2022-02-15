using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation.BusinessLogic
{
    public class CombineCoordinates : ICombineCoordinates
    {
        public List<Coordinates> CoordinatesList = new List<Coordinates>();

        IList<Coordinates> ICombineCoordinates.CoordinatesList { get => CoordinatesList; }

        public CombineCoordinates AddCoordinates(Coordinates coordinates)
        {
            this.CoordinatesList.Add(coordinates);
            return this;
        }
    }
}
