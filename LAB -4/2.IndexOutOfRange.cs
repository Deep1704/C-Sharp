/* Write a program that reads 5 numbers from user. Demonstrate concept of 
IndexOutOfRange Exception.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutOfBound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Index That you want: ");
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("Your Element= " + arr[index]);
                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.ReadLine();
            }
           
        }
    }
}
