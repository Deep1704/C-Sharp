/*Write a program to find out whether a given year is a leap year or not*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Year : ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y % 400 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else if (y % 100 == 0)
            {
                Console.WriteLine("Not Leap Year");
            }
            else if (y % 4 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
            Console.ReadLine();
        }
    }
}
