/*Write a program to create a delegate calculator to demonstrate the example of generic delegate.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Enter No 1: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter No 2: ");
        double y = double.Parse(Console.ReadLine());

        Program pr = new Program();
        MyDelegate<double> del1 = new MyDelegate<double>(pr.Addition);
        Console.WriteLine("Addition:          "+del1(x,y));

        MyDelegate<double> del2 = new MyDelegate<double>(pr.Subtraction);
        Console.WriteLine("Subtraction:       " + del2(x, y));

        MyDelegate<double> del3 = new MyDelegate<double>(pr.Multiplication);
        Console.WriteLine("Multiplication:    " + del3(x, y));

        MyDelegate<double> del4 = new MyDelegate<double>(pr.Division);
        Console.WriteLine("Division:          " + del4(x, y));

        Console.ReadLine();


    }

    public delegate T MyDelegate<T>(T x, T y);

    public double Addition(double x, double y)
    {

        return x + y;
    }

    public double Subtraction(double x, double y)
    {
        return x - y;
    }

    public double Multiplication(double x, double y)
    {
        return x * y;
    }

    public double Division(double x, double y)
    {
        return x / y;
    }
}

