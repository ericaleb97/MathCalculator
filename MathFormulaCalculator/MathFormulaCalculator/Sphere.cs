using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulaCalculator
{
    public class Sphere
    {
        public string units { get; set; }
        public double radius { get; set; }
        public double area { get; set; }
        public double volume { get; set; }
        public double height { get; set; }

        public void SphereArea()
        {
            Console.WriteLine("What are the units of measurement?");
            units = Console.ReadLine();
            Console.WriteLine("What is the radius?");
            radius = Convert.ToDouble(Console.ReadLine());
            area = 4 * Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of the sphere is: {0} {1}", area, units);
        }

        public void SphereVolume()
        {
            Console.WriteLine("What are the units of measurement?");
            units = Console.ReadLine();
            Console.WriteLine("What is the radius?");
            radius = Convert.ToDouble(Console.ReadLine());
            volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;
            Console.WriteLine("The volume of the sphere is: {0} {1}", volume, units);
        }

        public void SphereHeight()
        {
            Console.WriteLine("What are the units of measurement?");
            units = Console.ReadLine();
            Console.WriteLine("What is the radius?");
            radius = Convert.ToDouble(Console.ReadLine());
            height = radius * 2;
            Console.WriteLine("The volume of the sphere is: {0} {1}", height, units);
        }

        public void SphereRadius()
        {
            Console.WriteLine("What are the units of measurement?");
            units = Console.ReadLine();
            Console.WriteLine("What is the volume?");
            volume = Convert.ToDouble(Console.ReadLine());
            radius = Math.Pow((3 * (volume / (4 * Math.PI))), (double) 1 / 3);
            Console.WriteLine("The radius of the sphere is: {0} {1}", radius, units);
        }
    }
}
