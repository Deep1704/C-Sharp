using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff[] st = new Staff[5];

            for(int i=0; i<5; i++) {

                st[i]   = new Staff();
                st[i].GetStaffDetails();
            }

            for(int i=0; i<5; i++)
            {
                if (st[i].Department == "HOD")
                {
                    st[i].DisplayStaffDetails();
                   
                }
            }
            Console.ReadLine();
        }
       
    }
    class Staff
    {
        public string name;
        public string Department;
        public string Designation;
        public int Experience;
        public double Salary;

        public void GetStaffDetails()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter department: ");
            Department = Console.ReadLine();

            Console.WriteLine("Enter designation: ");
            Designation = Console.ReadLine();

            Console.WriteLine("Enter Experience: ");
            Experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Slary: " +Salary);
        }
    }
}
