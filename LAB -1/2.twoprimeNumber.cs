/*Write a program to get two numbers from user and print those two 
numbers.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine()); 

            int sum = a + b;
            Console.WriteLine("Addition of " + a + " and " + b + " is = " + sum);
            Console.ReadLine();

        }
    }
}
