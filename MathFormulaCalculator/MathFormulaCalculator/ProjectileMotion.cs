using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulaCalculator
{
    public class ProjectileMotion
    {
        public string distanceUnits { get; set; }
        public string timeUnits { get; set; }
        public double initialVelocity { get; set; }
        public double gravity = 9.81;
        public double airTime { get; set; }
        public double maxHeight { get; set; }
        public double startingHeight { get; set; }

        public double angle { get; set; }
        public double angleDegrees { get; set; }

        public double distance { get; set; }

        public double XInitialVelocity { get; set; }
        public double YInitialVelocity { get; set; }

        public void ProjectileCalculationOne()
        {
            Console.WriteLine("What are the units of distance?");
            distanceUnits = Console.ReadLine();

            Console.WriteLine("What are the units of time?");
            timeUnits = Console.ReadLine();

            Console.WriteLine("What is the max height?");
            maxHeight = Convert.ToDouble(Console.ReadLine());

            initialVelocity = Math.Sqrt(-2 * -gravity * maxHeight);
            Console.WriteLine("Initial Velocity: {0} {1}", initialVelocity, distanceUnits + "/" + timeUnits);

            airTime = (-2 * initialVelocity) / (-gravity);
            Console.WriteLine("Air Time: {0} {1}", airTime, timeUnits);
        }


        public void ProjectileCalculationTwo()
        {

            Console.WriteLine("What are the units of distance?");
            distanceUnits = Console.ReadLine();

            Console.WriteLine("What are the units of time?");
            timeUnits = Console.ReadLine();

            Console.WriteLine("What is the starting height?");
            startingHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the initial velocity?");
            initialVelocity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the angle?");
            angle = Convert.ToDouble(Console.ReadLine());

            angleDegrees = angle * Math.PI / 180;

            XInitialVelocity = initialVelocity * Math.Cos(angleDegrees);
            YInitialVelocity = initialVelocity * Math.Sin(angleDegrees);

            airTime = (2 * YInitialVelocity) / gravity;
            Console.WriteLine("Air Time: {0} {1}", airTime, timeUnits);

            distance = (Math.Pow(initialVelocity, 2) * Math.Sin(2 * angleDegrees)) / gravity;
            Console.WriteLine("Distance: {0} {1}", distance, distanceUnits);

            maxHeight = startingHeight + (Math.Pow(initialVelocity, 2) * Math.Pow(Math.Sin(angleDegrees), 2)) / (2 * gravity);
            Console.WriteLine("Max Height: {0} {1}", maxHeight, distanceUnits);
        }
    }
}
