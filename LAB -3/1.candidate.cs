/*Write a program to create a class named Candidate with ID, Name, Age, 
Weight and Height as data members & also create a member functions like 
GetCandidateDetails() and DisplayCandidateDetails().*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candidate a1 = new Candidate();
            a1.GetCandidaetDetails();
            a1.DisplayCandidateDetails();
            Console.ReadLine();
        }

        class Candidate
        {
            public int id;
            public string name;
            public int Age;
            public double weight;
            public double height;

            public void GetCandidaetDetails()
            {
                Console.WriteLine("Enter ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();

                Console.WriteLine("Enter Age: ");
                Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter height: ");
                height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Weight: ");
                weight = Convert.ToDouble(Console.ReadLine());
            }

            public void DisplayCandidateDetails()
            {
                Console.WriteLine("----------------");
                Console.WriteLine("ID = "+id);
                Console.WriteLine("Name = "+name);
                Console.WriteLine("Age = "+Age);
                Console.WriteLine("Weight = "+height);
                Console.WriteLine("height = "+weight);

            }
        }
    }
}
