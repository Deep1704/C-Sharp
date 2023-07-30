/*. Write a program to calculate area of a Rectangle using constructor.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Breadth: ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            AreaOfRectangle a1 = new AreaOfRectangle(length, breadth);

            Console.WriteLine("Area of Reactangle: " +a1.CalculateArea());
            Console.ReadLine();

        }

        class AreaOfRectangle
        {
            double length;
            double breadth;

            public AreaOfRectangle(double length, double breadth)
            {
                this.length = length;
                this.breadth = breadth;
            }

           public double CalculateArea()
            {
                return this.length * this.breadth;
            }
        }


    }
}
