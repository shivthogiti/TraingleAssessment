using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculation.BusinessLogic
{
    public class SelectedTriangleColumnAndRow : ISelectedTriangleColumnAndRow
    {
        public char Row { get; set; }

        public int Column { get; set; }

        public SelectedTriangleColumnAndRow(char row , int column)
        {
            this.Row = row;
            this.Column = column;
        }
    }
}
