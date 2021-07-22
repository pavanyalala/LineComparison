using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class LengthCalculation
    {
        int PointX1, PointX2, PointY1, PointY2;//variables
        public LengthCalculation(int PointX1, int PointX2, int PointY1, int PointY2)//constructor to initialize variable
        {
            this.PointX1 = PointX1;
            this.PointX2 = PointX2;
            this.PointY1 = PointY1;
            this.PointY2 = PointY2;

        }
        public double CalculateLength()//method calculate length of line
        {
            double length = Math.Sqrt((PointX2 - PointX1) ^ 2 + (PointY2 - PointY1) ^ 2);
            return length;
        }

    }
}
