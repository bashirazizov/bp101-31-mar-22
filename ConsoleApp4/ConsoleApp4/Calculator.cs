using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    static class Calculator
    {
        public static double pi { get; set; }

        public static int Sum(int a , int b)
        {
            return a + b;
        }

        public static double CalcuateCircleArea(int radius)
        {
            return radius * radius;
        }
    }
}
