using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point pOne = new Point(1, 2);
            Point pTwo = new Point(3, 4);
            Point pThree = new Point(1, 2);

            Console.WriteLine(pOne.Equals(pTwo)); // false
            Console.WriteLine(pOne.Equals(pThree)); // true

            Line line_First = new Line(pOne, pTwo);
            Line line_Second = new Line(pOne, pThree);

            Console.WriteLine(line_First.Equals(line_Second)); // false

            Console.WriteLine(pOne.CompareTo(pTwo)); // -1
            Console.WriteLine(pOne.CompareTo(pThree)); // 0
            Console.WriteLine(pTwo.CompareTo(pOne)); // 1

            Console.ReadLine();
        }
    }
}
