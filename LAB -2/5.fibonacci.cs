﻿/*Write a program to print Fibonacci series*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = 0; int n2 = 1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (int i = 2; i < n; i++)
            {
                int n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;

           
            }
            Console.ReadLine();
        }
    }
}
