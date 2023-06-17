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
            Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Line line = new Line(x1, y1, x2, y2);
            double length = line.CalculateLength();
            Console.WriteLine("The length of the line is: " + length);

            Console.ReadLine();
        }
    }
}
