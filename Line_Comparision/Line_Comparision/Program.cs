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
            Console.WriteLine("Enter the coordinates of the first point of Line1 (x1, y1):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point of Line1 (x2, y2):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the first point of Line2 (a1, b1):");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the first point of Line2 (a2, b2):");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());

            Line line = new Line(x1, y1, x2, y2, a1, b1, a2, b2);
            //double length = Convert.ToDouble(line.CalculateLength());
            line.CalculateLength();
            //Console.WriteLine("The length of the line is: " + length);

            Console.ReadLine();
        }
    }
}
