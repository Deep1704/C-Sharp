using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            Appolo appolo = new Appolo();
            Wockhardt wockhardt = new Wockhardt();
            Gokul_Superspeciality gokul_superspeciality = new Gokul_Superspeciality();

            hospital.HospitalDetails();
            appolo.HospitalDetails();
            wockhardt.HospitalDetails();
            gokul_superspeciality.HospitalDetails();

            Console.ReadLine();
        }

        class Hospital
        {
            public virtual void HospitalDetails()
            {
                System.Console.WriteLine("General Hospital Details (Parent Class)");
            }
        }
        class Appolo : Hospital
        {
            override public void HospitalDetails()
            {
                Console.WriteLine("Appolo Hospital Details (Child Class)");
            }
        }

        class Wockhardt : Hospital
        {
            override public void HospitalDetails()
            {
                Console.WriteLine("Wockhardt Hospital Details (Child Class)");
            }
        }
        class Gokul_Superspeciality : Hospital
        {
            override public void HospitalDetails()
            {
                Console.WriteLine("Gokul_Superspeciality Hospital Details (Child Class)");
            }
        }
    }
}
