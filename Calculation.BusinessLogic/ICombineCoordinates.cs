using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation.BusinessLogic
{
    public interface ICombineCoordinates
    {
         IList<Coordinates> CoordinatesList { get; }
         CombineCoordinates AddCoordinates(Coordinates coordinates);
      
    }
}
