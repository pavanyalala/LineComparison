using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program");

            LengthCalculation lengthCalculation = new LengthCalculation(2, 4, 3, 9);
            double line1 = lengthCalculation.CalculateLength();
            Console.WriteLine("Length of Line one : " + line1);

            LengthCalculation lengthCalculation1 = new LengthCalculation(3, 9, 4, 12);
            double line2 = lengthCalculation1.CalculateLength();
            Console.WriteLine("Length of Line Two : " + line2);

            if (line1.CompareTo(line2) > 0)
                Console.WriteLine("Line1 is Greater than Line2");
            if (line1.CompareTo(line2) < 0)
                Console.WriteLine("Line1 is Less than Line2");
            else
                Console.WriteLine("Both Line1 and Line2 Are Equal");



        }
    }
}
