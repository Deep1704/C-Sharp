/*Write a program to Swapping without using third variable.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1P10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine()); 

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);

            Console.ReadLine();
        }
    }
}
