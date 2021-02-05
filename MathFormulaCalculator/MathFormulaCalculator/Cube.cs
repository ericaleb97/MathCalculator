using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulaCalculator
{
    public class Cube
    {
        public double sideLength { get; set; }
        public string units { get; set; }
        public double cube { get; set; }

        public void Questions()
        {
            Console.WriteLine("What are you measuring?");
            Console.WriteLine("Area: 1");
            Console.WriteLine("Volume: 2");
        }

        public void CubeArea()
        {
            Console.WriteLine("What are the units of measurement?");
            units = Console.ReadLine();
            Console.WriteLine("What is the side length?");
            sideLength = Convert.ToDouble(Console.ReadLine());
            cube = 6 * Math.Pow(sideLength, 2);
            Console.WriteLine("The area of the cube is: {0} {1}", cube, units);
        }
        public void CubeVolume()
        {
            Console.WriteLine("What are the units of measurement?");
            units = Console.ReadLine();
            Console.WriteLine("What is the side length?");
            sideLength = Convert.ToDouble(Console.ReadLine());
            cube = Math.Pow(sideLength, 3);
            Console.WriteLine("The volume of the cube is: {0} {1}", cube, units);
        }
    }
}
