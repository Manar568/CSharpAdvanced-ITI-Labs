using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day01
{
    internal class Square :IShape,IColor
    {
        
        public double SideLength { get; set; }


        public double CalculateArea()
        {
            return SideLength* SideLength;

        }

        public double CalculatePerimeter()
        {
            return SideLength * 2;
        }

        public string GetColor()
        {
            return "Yellow";
        }
    }
}
