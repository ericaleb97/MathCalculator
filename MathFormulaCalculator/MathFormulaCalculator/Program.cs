using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var cylinder = new Cylinder();
            var cube = new Cube();
            var sphere = new Sphere();
            var projectileMotion = new ProjectileMotion();
            var tension = new Tension();
            var graphingLines = new GraphingLines();
            var dotProduct = new DotProduct();

            Console.WriteLine("Hi! Welcome to the math problem solver!");
            Console.WriteLine("What is the subject?");
            Console.WriteLine("Shapes: 1");
            Console.WriteLine("Projectile Motion: 2");
            Console.WriteLine("Tension: 3");
            Console.WriteLine("Is a point on a line: 4");
            Console.WriteLine("Finding the angle between two points (Dot Product): 5");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("What is the shape?");
                Console.WriteLine("Cylinder: 1");
                Console.WriteLine("Cube: 2");
                Console.WriteLine("Sphere: 3");

                int shape = Convert.ToInt32(Console.ReadLine());

                if (shape == 2)
                {
                    cube.Questions();
                }
                else
                {
                    Console.WriteLine("What are you measuring?");
                    Console.WriteLine("Area: 1");
                    Console.WriteLine("Volume: 2");
                    Console.WriteLine("Height: 3");
                    Console.WriteLine("Radius: 4");
                }

                int measure = Convert.ToInt32(Console.ReadLine());

                if (shape == 1 && measure == 1)
                {
                    cylinder.CylinderArea();
                }

                if (shape == 1 && measure == 2)
                {
                    cylinder.CylinderVolume();
                }

                if (shape == 1 && measure == 3)
                {
                    cylinder.CylinderHeight();
                }

                if (shape == 1 && measure == 4)
                {
                    cylinder.CylinderRadius();
                }

                if (shape == 2 && measure == 1)
                {
                    cube.CubeArea();
                }

                if (shape == 2 && measure == 2)
                {
                    cube.CubeVolume();
                }

                if (shape == 3 && measure == 1)
                {
                    sphere.SphereArea();

                }

                if (shape == 3 && measure == 2)
                {
                    sphere.SphereVolume();
                    sphere.SphereHeight();
                }

                if (shape == 3 && measure == 3)
                {
                    sphere.SphereHeight();
                }

                if (shape == 3 && measure == 4)
                {
                    sphere.SphereRadius();
                }
            }

            if (option == 2)
            {
                Console.WriteLine("What are you trying to find?");
                Console.WriteLine("Type one of the following:");
                Console.WriteLine("Initial Velocity & Air Time (Vertical): 1");
                Console.WriteLine("Air Time, Distance & Max Height: 2");

                int pmOption = Convert.ToInt32(Console.ReadLine());

                if (pmOption == 1)
                {
                    projectileMotion.ProjectileCalculationOne();
                }

                if (pmOption == 2)
                {
                    projectileMotion.ProjectileCalculationTwo();
                }
                
            }

            if (option == 3)
            {
                tension.UserSetUp();
                tension.CalculateXForces();
                tension.CalculateYForces();
                tension.CalculateΣFX();
                tension.CalculateΣFY();
                tension.CalculateT1();
                tension.CalculateT2();
                tension.Results();
            }

            if (option == 4)
            {
                graphingLines.UserSetUp();
                graphingLines.CalculatingD();
                graphingLines.CalculatingOnLine();
                graphingLines.Results();
            }

            if (option == 5)
            {
                dotProduct.UserSetup();
                dotProduct.CalculatingVectorLengths();
                dotProduct.CalculatingDotProduct();
                dotProduct.CaulculatingAngle();
                dotProduct.Results();
            }

            Console.ReadLine();
        }
    }
}
