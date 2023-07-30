/*Create a class named RBI with calculateInterest() method. Create another 
classes HDFC, SBI, ICICI which overrides calculateInterest() meth*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RBI rBI = new RBI();
            HDFC hdFC = new HDFC();
            SBI sBI = new SBI();
            ICICI icICI = new ICICI();

            rBI.calculateInterest();
            hdFC.calculateInterest();
            sBI.calculateInterest();
            icICI.calculateInterest();

            Console.ReadLine();
        }
        class RBI
        {
            public virtual void calculateInterest()
            {
                Console.WriteLine("Interest of SBI");
            }
        }
        class HDFC : RBI
        {
            override public void calculateInterest()
            {
                Console.WriteLine("Interest of RBI");
            }
        }
        class SBI : RBI
        {
            override public void calculateInterest()
            {
                Console.WriteLine("Interest of SBI");
            }
        }
        class ICICI : RBI
        {
            override public void calculateInterest()
            {
                Console.WriteLine("Interest of ICICI");
            }
        }
    }
}
