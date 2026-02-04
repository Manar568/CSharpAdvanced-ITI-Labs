using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day01
{
    internal class Circle : IShape,IColor
    {
       public double Radius { get; set; }
       // public string Color { get; set; }

      public double CalculateArea()
        {
            return .5* Radius* Radius;

        }

        public double CalculatePerimeter()
        {
           return Math.PI* Radius*2;
        }

        public string GetColor()
        {
            return "RED";
        }
    }
}
