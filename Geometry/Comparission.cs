using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Comparission
    {
        public void ComparingLines()
        {
            LengthCalculation line1 = new LengthCalculation(1, 2, 3, 4);
            LengthCalculation line2 = new LengthCalculation(1, 2, 3, 4);
            int line1Length = Convert.ToInt32(line1.CalculateLength());
            int line2Length = Convert.ToInt32(line2.CalculateLength());
            if (line1Length.CompareTo(line2Length) > 0)
                Console.WriteLine("Line 1 is Greaterthan Line 2");
            else if (line1Length.CompareTo(line2Length) < 0)
                Console.WriteLine("Line 1 is Lessthan Line 2");
            else
                Console.WriteLine("Both the Lines Are Equal");
        }
    }
}
