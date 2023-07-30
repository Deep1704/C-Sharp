/*Write a program to Define a class Distance have data members dist1, dist2, 
dist3. Initialize the two data members using constructor and store their 
addition in third data member using function and display addition.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Distance1: ");
            double dist1  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Distance2: ");
            double dist2 = Convert.ToDouble(Console.ReadLine());

            Distance d1 = new Distance(dist1,dist2);
            d1.sum();
            d1.Display();

            Console.ReadLine();

        }
    }

    class Distance
    {
        public double dist1;
        public double dist2;
        public double dist3;

        public Distance(double dist1, double dist2)
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
        }

        public void sum()
        {
            this.dist3 = this.dist1 + this.dist2;
        }

        public void Display()
        {
            Console.WriteLine("Total Distance: "+this.dist3);
        }
    }
}
