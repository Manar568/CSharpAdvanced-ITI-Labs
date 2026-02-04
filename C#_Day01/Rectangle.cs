using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day01
{
    internal class Rectangle : IShape, IColor
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width*Height;

        }

        public double CalculatePerimeter()
        {
            return Width * Height * 2;
        }

        public string GetColor()
        {
            return "Grean";
        }

        /*public void test()
        {
            Console.WriteLine("testtt");
        }

        public string test()
        {
            return "ttessst";
        }*/
    }
}
