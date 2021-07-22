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

        }
    }
}
