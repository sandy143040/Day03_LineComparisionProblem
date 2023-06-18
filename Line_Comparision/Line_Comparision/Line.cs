using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    public class Line
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        private double a1;
        private double b1;
        private double a2;
        private double b2;

        public Line(double x1, double y1, double x2, double y2, double a1, double b1, double a2, double b2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.a1 = a1;
            this.b1 = b1;
            this.a2 = a2;
            this.b2 = b2;
        }

        public void CalculateLength()
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double deltaA = a2 - a1;
            double deltaB = b2 - b1;

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
