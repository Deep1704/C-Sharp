/*Write a program to find out Simple Interest using function. (I = PRN/100)*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1P7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter P : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter R : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Simple Intrest : " + (p * r * n) / 100);

            Console.ReadLine();
        }
    }
}
