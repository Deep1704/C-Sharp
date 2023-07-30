/*Write a program to create a Simple Calculator for two numbers (Addition, 
Multiplication, Subtraction, Division) [Also using if…else & Switch Case]
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1P8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Using if/else

            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Choice : ");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == '+')
            {
                Console.WriteLine("Addition : " + (num1 + num2));
            }
            else if (choice == '-')
            {
                Console.WriteLine("Subtraction : " + (num1 - num2));
            }
            else if (choice == '*')
            {
                Console.WriteLine("Multiplication : " + (num1 * num2));
            }
            else if (choice == '/')
            {
                Console.WriteLine("Division : " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Modulo : " + (num1 % num2));
            }
        }
    }
}
