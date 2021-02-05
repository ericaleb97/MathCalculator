using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulaCalculator
{
    public class GraphingLines
    {
        public double c1 { get; set; }
        public double c2 { get; set; }
        public double c3 { get; set; }

        public double x1 { get; set; }
        public double y1 { get; set; }
        public double z1 { get; set; }

        public double x2 { get; set; }
        public double y2 { get; set; }
        public double z2 { get; set; }

        public double d { get; set; }

        public double d1 { get; set; }
        public double d2 { get; set; }
        public double d3 { get; set; }

        public double EQ1 { get; set; }
        public double EQ2 { get; set; }
        public double EQ3 { get; set; }

        public void UserSetUp()
        {
            Console.WriteLine("What is the first point of C?");
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the second point of C?");
            c2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the third point of C?");
            c3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the first point of A?");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the second point of A?");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the third point of A?");
            z1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the first point of B?");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the second point of B?");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the third point of B?");
            z2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
        }

        public void CalculatingD()
        {
            d1 = x2 - x1;
            d2 = y2 - y1;
            d3 = z2 - z1;
        }

        public void CalculatingOnLine()
        {
            EQ1 = x1 + (d1 * d1);
            EQ2 = y1 + (d2 * d1);
            EQ3 = z1 + (d3 * d1);
        }

        public void Results()
        {
            if (c1 == EQ1 && c2 == EQ2 && c3 == EQ3)
                Console.WriteLine("The point C = ({0}, {1}, {2}) is on the line through A = ({3}, {4}, {5}) and B = ({6}, {7}, {8})", c1, c2, c3, x1, y1, z1, x2, y2, z2);
            else
                Console.WriteLine("The point C = ({0}, {1}, {2}) is not on the line through A = ({3}, {4}, {5}) and B = ({6}, {7}, {8})", c1, c2, c3, x1, y1, z1, x2, y2, z2);
        }
    }
}
