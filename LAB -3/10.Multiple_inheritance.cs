﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary s = new Salary();
            s.basic_sal();
            s.display_sal();
            s.gross_sal();
            Console.ReadLine();
        }
        class Employee
        {
            string name;
            public double basic_salary;

            public void basic_sal()
            {
                Console.WriteLine("Please enter basic salary : ");
                this.basic_salary = double.Parse(Console.ReadLine());
            }
        }

        interface Gross
        {
             void gross_sal();
        }

        class Salary : Employee, Gross
        {
            double hra = 0.2, ta = 0.2, da = 0.4;
            public void gross_sal()
            {
                Console.WriteLine("Gross salary : {0}", (basic_salary + basic_salary * hra + ta + basic_salary * da));
            }
            public void display_sal()
            {
                Console.WriteLine("Salary : {0}", (basic_salary + hra + ta + da));
            }
        }

    }
}
