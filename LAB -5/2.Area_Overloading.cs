﻿/*  Write a program using method overloading by changing number of 
arguments to calculate area of square and rectangle*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadingdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of Square : ");
            double l = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Length of Rectangle : ");
            double l2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter breadth of Recangle : ");
            double b2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Area of Square = " + Area(l));
            Console.WriteLine("Area of Rectangle = " + Area(l2, b2));

            Console.ReadLine();
        }

        public static double Area(double l)
        {
            return l * l;
        }
        public static double Area(double l, double b)
        {
            return l * b;
        }
    }
}
