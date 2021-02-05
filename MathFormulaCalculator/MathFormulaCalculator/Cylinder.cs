using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulaCalculator
{
    public class Cylinder
    {
        public string units { get; set; }
        public double radius { get; set; }
        public double height { get; set; }
        public double volume { get; set; }
        public double area { get; set; }

        public void CylinderArea()
        {
            Console.WriteLine("What are the units of measurement?");
            units = Console.ReadLine();
            Console.WriteLine("What is the radius?");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the height?");
            height = Convert.ToDouble(Console.ReadLine());
            area = (2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, 2));
            Console.WriteLine("The area of the cylinder is: {0} {1}", area, units);
        }

        public void CylinderVolume()
        {
            Console.WriteLine("What are the units of measurement?");
            units = Console.ReadLine();
            Console.WriteLine("What is the radius?");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the height?");
            height = Convert.ToDouble(Console.ReadLine());
            volume = (Math.PI * Math.Pow(radius, 2) * height);
            Console.WriteLine("The volume of the cylinder is: {0} {1}", volume, units);
        }

        public void CylinderHeight()
        {
            Console.WriteLine("What are the units of measurement?");
            units = Console.ReadLine();
            Console.WriteLine("What is the radius?");
            
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the area?");
            area = Convert.ToDouble(Console.ReadLine());
            height = area / (2 * Math.PI * radius) - radius;
            Console.WriteLine("The height of the cylinder is: {0} {1}", height, units);
        }

        public void CylinderRadius()
        {
            Console.WriteLine("What are the units of measurement?");
            units = Console.ReadLine();
            Console.WriteLine("What is the height?");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the area?");
            area = Convert.ToDouble(Console.ReadLine());
            radius = 0.5 * Math.Sqrt(Math.Pow(height, 2) + (2 * (area / Math.PI))) - height / 2;
            Console.WriteLine("The radius of the cylinder is: {0} {1}", radius, units);
        }
    }
}
