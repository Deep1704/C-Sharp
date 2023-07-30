/*Write a program to Define a class Salary which will contain member 
variable Basic, TA, DA, HRA. Write a program using Constructor with default
values for DA and HRA and calculate the salary of employee.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary s1 = new Salary();
            s1.CalculateSalary();

            Console.ReadLine();
        }
    }
    class Salary
    {
        public double TA;
        public double HRA;
        public double DA;
        public double Basic;

        public Salary()
        {
            Console.WriteLine("Enter TA Salary: ");
            TA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Basic Salary: ");
            Basic = Convert.ToDouble(Console.ReadLine());

            DA = 25000;
            HRA = 12000;
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Gross Salary: " + (Basic + TA + DA + HRA));
        }
    }
}
