/*Write a pogram to Create a class Bank_Account with Account_No, Email, 
User_Name, Account_Type and Account_Balance as data members. Also 
create a Member function GetAccountDetails() & DisplayAccountDetails()*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_Account ac = new Bank_Account();
            ac.GetAccountDetails();
            ac.DisplayAccountDetails();
            Console.ReadLine();
        }

        class Bank_Account
        {
            public int Account_No;
            public string Email;
            public string User_Name;
            public string Account_Type;
            public int Account_Balance;

            public void GetAccountDetails()
            {
                Console.WriteLine("Enter account_no: ");
                Account_No = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Email: ");
                Email = Console.ReadLine();

                Console.WriteLine("Enter User_Name: ");
                User_Name = Console.ReadLine();

                Console.WriteLine("Enter account_type: ");
                Account_Type = Console.ReadLine();

                Console.WriteLine("Enter account_balance: ");
                Account_Balance = Convert.ToInt32(Console.ReadLine());
            }

            public void DisplayAccountDetails()
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Account_no: "+Account_No);
                Console.WriteLine("Email: " + Email);
                Console.WriteLine("UserName: " + User_Name);
                Console.WriteLine("Account_Type: " + Account_Type);
                Console.WriteLine("Account_balance: " + Account_Balance);


            }
        }
    }
}
