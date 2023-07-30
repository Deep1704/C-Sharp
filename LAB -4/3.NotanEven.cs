/*Write a program to accept a number from the user and throw an exception 
if the number is not an even number.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotanEven
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even Number : " + num);
                    Console.ReadLine();
                }
                else
                {
                    throw new OddNumberException("Not Even Number");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
    class OddNumberException : Exception
    {
        public OddNumberException(String message) : base(message) { }

    }
}
