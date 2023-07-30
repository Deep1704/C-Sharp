/*Write a program to create interface Calculate. In this interface we have two 
member functions Addition() and Subtraction(). Implements this interface 
in another class named Result.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Calculate
{
      int Addition(int a, int b);
      int Subtraction(int a, int b);
}

  public class Result : Calculate
{
    public int Addition(int a, int b)
    {
        return a + b;
    }
    public int Subtraction(int a, int b)
    {
        return a - b;
    }
}
public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter no. 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no. 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Result r1 = new Result();
            Console.WriteLine("Addition: ",r1.Addition(a,b));
            Console.WriteLine("Subtraction: ", r1.Subtraction(a, b));
            Console.ReadLine();
        }
    }

   

  
