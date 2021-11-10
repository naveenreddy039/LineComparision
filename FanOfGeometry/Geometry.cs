using System;
using System.Collections.Generic;
using System.Text;

namespace FanOfGeometry
{
    public class Geometry
    {
        public void printLength()
        {
            int a1 = 3;
            int b1 = 4;
            int a2 = 4;
            int b2 = 3;
            double x1 = Math.Pow(a2 - a1, 2);
            double x2 = Math.Pow(b2 - b1, 2);
            double x3 = Math.Sqrt(x1 + x2);
           
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.ReadKey();
        }
    }
}
