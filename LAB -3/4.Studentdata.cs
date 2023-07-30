/*Write a program with following specifications: 
Class Name: Student
Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
Get Students Details using constructor and DisplayStudentDetails() using 
member function.*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetStudentDetails();
            s1.DisplayStudentDetails();
            Console.ReadLine();
        }

        class Student
        {
            public int Enrollment_No;
            public string Student_Name;
            public int Semester;
            public int SPI;
            public int CPI;

            public void GetStudentDetails()
            {
                Console.WriteLine("Enter Enrollment_no: ");
                Enrollment_No = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student_name: ");
                Student_Name = Console.ReadLine();

                Console.WriteLine("Enter Semester: ");
                Semester = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter CPI: ");
                SPI = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter CPI: ");
                CPI = Convert.ToInt32(Console.ReadLine());
            }

            public void DisplayStudentDetails()
            {
                Console.WriteLine("---------");
                Console.WriteLine("Enrollment_No: "+Enrollment_No);
                Console.WriteLine("Student_name: " + Student_Name);
                Console.WriteLine("Semester: " + Semester);
                Console.WriteLine("SPI: " + SPI);
                Console.WriteLine("CPI: " + CPI);
            }
        }
    }
}
