using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation.BusinessLogic
{
    public interface ISelectedTriangleColumnAndRow
    {
        char Row { get; set; }

        int Column { get; set; }
    }
}
