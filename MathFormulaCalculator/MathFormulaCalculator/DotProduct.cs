using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulaCalculator
{
    public class DotProduct
    {
        double a1 { get; set; }
        double a2 { get; set; }
        double a3 { get; set; }

        double vectorLengthA { get; set; }

        double b1 { get; set; }
        double b2 { get; set; }
        double b3 { get; set; }

        double vectorLengthB { get; set; }
        double dotProduct { get; set; }
        double angle1 { get; set; }

        double angle2 { get; set; }
        public double angleDegrees { get; set; }

        public void UserSetup()
        {
            Console.WriteLine("What is the first point of A?");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the second point of A?");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the third point of A?");
            a3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the first point of B?");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the second point of B?");
            b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the third point of B?");
            b3 = Convert.ToDouble(Console.ReadLine());
        }

        public void CalculatingVectorLengths()
        {
            vectorLengthA = Math.Sqrt((Math.Pow(a1, 2) + Math.Pow(a2, 2) + Math.Pow(a3, 2)));
            vectorLengthB = Math.Sqrt((Math.Pow(b1, 2) + Math.Pow(b2, 2) + Math.Pow(b3, 2)));
        }

        public void CalculatingDotProduct()
        {
            dotProduct = ((a1 * b1) + (a2 * b2) + (a3 * b3));
        }

        public void CaulculatingAngle()
        {
            angle1 = dotProduct / (vectorLengthA * vectorLengthB);
            
            angle2 = Math.Acos(angle1);

            angleDegrees = angle2 * 180 / Math.PI;
        }
        public void Results()
        {
            Console.WriteLine("The angle between <{0}, {1}, {2}> and <{3}, {4}, {5}> is {6}", a1, a2, a3, b1, b2, b3, angleDegrees);
        }
    }
}
