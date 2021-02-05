using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulaCalculator
{
    public class Tension
    {
        public double T1Angle { get; set; }
        public double T2Angle { get; set; }
        public double T1X { get; set; }
        public double T1Y { get; set; }
        public double T2X { get; set; }
        public double T2Y { get; set; }
        public double T3N { get; set; }
        public double ΣFX { get; set; }
        public double ΣFY { get; set; }
        public double T1N { get; set; }
        public double T2N { get; set; }
        public double T1XN { get; set; }
        public double weight { get; set; }
        public double angleDegreesXT1 { get; set; }
        public double angleDegreesXT2 { get; set; }
        public double angleDegreesYT1 { get; set; }
        public double angleDegreesYT2 { get; set; }

        public double gravity = 9.81;

        public Tension()
        {

        }

        public void UserSetUp()
        {
            Console.WriteLine("What is the weight?");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the angle for T1?");
            T1Angle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the angle for T2?");
            T2Angle = Convert.ToDouble(Console.ReadLine());
        }

        public void CalculateXForces()
        {
            angleDegreesXT1 = T1Angle * Math.PI / 180;
            angleDegreesXT2 = T2Angle * Math.PI / 180;

            T1X = Math.Cos(angleDegreesXT1);
            T2X = Math.Cos(angleDegreesXT2);
        }

        public void CalculateYForces()
        {
            T3N = gravity * weight;

            angleDegreesYT1 = T1Angle * Math.PI / 180;
            angleDegreesYT2 = T2Angle * Math.PI / 180;

            T1Y = Math.Sin(angleDegreesYT1);
            T2Y = Math.Sin(angleDegreesYT2);
        }

        public void CalculateΣFX()
        {
            ΣFX = T1X / T2X;
        }

        public void CalculateΣFY()
        {
            ΣFY = (T2Y * ΣFX) + T1Y;
        }

        public void CalculateT1()
        {
            T1N = T3N / ΣFY;
        }

        public void CalculateT2()
        {
            T2N = ΣFX * T1N;
        }

        public void Results()
        {
            Console.WriteLine("T1: {0}", T1N);
            Console.WriteLine("T2: {0}", T2N);
            Console.WriteLine("T3: {0}", T3N);
        }
    }
}
