/*Write a program using method overloading by changing datatype of 
arguments to perform addition of two integer numbers and two float 
numbers.*/



using System;

namespace Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Integer number : ");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Integer number : ");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1st float number : ");
            float a2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd float number : ");
            float b2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Addition of Integers = " + Addition(a1, b1));
            Console.WriteLine("Addition of float = " + Addition(a2, b2));

            Console.ReadLine();

        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static float Addition(float a, float b)
        {
            return a + b;
        }
    }
}

