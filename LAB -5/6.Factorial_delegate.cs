/*Write a program to return the factorial from the method using delegate.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            MyDelegate del = new MyDelegate(p1.Fact);
            Console.WriteLine(del(5));
            Console.ReadLine();
        }

        public delegate int MyDelegate(int x);

        public int Fact(int x)
        {
            if(x == 1)
            {
                return 1;
            }
            else
            {
                return x * Fact(x - 1);
            }
        }
    }
}
