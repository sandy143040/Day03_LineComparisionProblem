using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    public class Point : IComparable<Point>
    {
        public int First { get; set; }
        public int Second { get; set; }

        public Point(int first, int second)
        {
            First = first;
            Second = second;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point otherPoint = (Point)obj;
            return First == otherPoint.First && Second == otherPoint.Second;
        }

        public int CompareTo(Point other)
        {
            if (other == null)
                return 1;

            if (First == other.First && Second == other.Second)
                return 0;

            // Compare based on First first, then Second
            if (First != other.First)
                return First.CompareTo(other.First);

            return Second.CompareTo(other.Second);
        }
    }
}
