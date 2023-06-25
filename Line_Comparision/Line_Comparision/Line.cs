using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    public class Line
    {
        private double xOne;
        private double yOne;
        private double xTwo;
        private double yTwo;
        private double aOne;
        private double bOne;
        private double aTwo;
        private double bTwo;

        public Line(double xOne, double yOne, double xTwo, double yTwo, double aOne, double bOne, double aTwo, double bTwo)
        {
            this.xOne = xOne;
            this.yOne = yOne;
            this.xTwo = xTwo;
            this.yTwo = yTwo;
            this.aOne = aOne;
            this.bOne = bOne;
            this.aTwo = aTwo;
            this.bTwo = bTwo;
        }

        public void CalculateLength()
        {
            double deltaX = xTwo - xOne;
            double deltaY = yTwo - yOne;
            double deltaA = aTwo - aOne;
            double deltaB = bTwo - bOne;

            double lengthOfLine1 = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            Console.WriteLine("Length of Line1 is: "+ lengthOfLine1);

            double lengthOfLine2 = Math.Sqrt(Math.Pow(deltaA, 2) + Math.Pow(deltaB, 2));
            Console.WriteLine("Length of Line2 is: "+ lengthOfLine2);

            //Comparing Line1 and Line2
            if (lengthOfLine1.Equals(lengthOfLine2))
            {
                Console.WriteLine("Two lines are equal in length.");
            }
            else if(lengthOfLine1 > lengthOfLine2)
            {
                Console.WriteLine("Line 1 is greater in length than Line 2.");
            }
            else
            {
                Console.WriteLine("Line 1 is greater in length than Line 2.");
            }
        }
    }
}
