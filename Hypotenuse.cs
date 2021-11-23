using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class Hypotenuse
    {
        public double side1, side2, side3;
        //constructor
        public Hypotenuse(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
            side3 = 0.00;
        }
        //method to calculate the hypotenuse
        public double CalculateHypotenuse(double side1, double side2)
        {
            /*square side1 and side2
             * and assigns value to side3
             */
            side3 = (side1 * side1) + (side2 * side2);
            //computes the square root of side3
            side3 = Math.Round(Math.Sqrt(side3), 2);
            //returns side3
            return side3;
        }
    }
}
