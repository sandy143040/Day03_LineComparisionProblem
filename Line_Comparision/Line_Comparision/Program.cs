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
            double xOne = Convert.ToDouble(Console.ReadLine());
            double yOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point of Line1 (x2, y2):");
            double xTwo = Convert.ToDouble(Console.ReadLine());
            double yTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the first point of Line2 (a1, b1):");
            double aOne = Convert.ToDouble(Console.ReadLine());
            double bOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the first point of Line2 (a2, b2):");
            double aTwo = Convert.ToDouble(Console.ReadLine());
            double bTwo = Convert.ToDouble(Console.ReadLine());

            Line line = new Line(xOne, yOne, xTwo, yTwo, aOne, bOne, aTwo, bTwo);
            line.CalculateLength();

            Console.ReadLine();
        }
    }
}
