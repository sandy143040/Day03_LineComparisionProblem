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

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double CalculateLength()
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double length = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            return length;
        }
    }
}
