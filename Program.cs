using System;
using System.Collections;
using System.Collections.Generic;

namespace BankSimulationApp
{
    class Program
    {
        public static List<Account> AccountList = new List<Account>();
        public static List<Transaction> TransactionsList = new List<Transaction>();
        public void CreateAccount()
        {
            Console.WriteLine("Enter Account Holder Name: ");
            string aName = Console.ReadLine();
            Console.WriteLine("Enter Account Number");
            int aNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the date of creation of Account:");
            DateTime aDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Balance: ");
            double aBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the type of Account : 1. Savings or 2. Current");
            int aType = Convert.ToInt32(Console.ReadLine());

            Account a = new Account(aName, aNumber, aDate, aBalance,aType);
            AccountList.Add(a);
            

        }
        public void display()
        {
            foreach(Account item in AccountList)
            {
                Console.WriteLine(item);
                Console.WriteLine("{0}\n {1}\n {2}\n {3}\n {4}", item.AccountHolderName,item.AccountNumber, item.AccountCreationDate, item.AccountBalance, item.AType);
            }
        }
        
        static void Main(string[] args)
        {
            
            Program p = new Program();
            Console.WriteLine("Welcome to the Bank \n -------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Select from the Following Options:\n 1. Create an Account\n 2. Remove an Account\n 3. Deposit Money to your Account\n 4. Withdraw Money from Your Account\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (choice)
                {
                    case 1:
                        p.CreateAccount();
                        break;
                    case 2:
                        p.display();
                        break;
                    default: 
                        break;
                        //case 2:
                        //    p.RemoveAccount();
                        //    break;
                        //case 3:
                        //    p.DepositMoney();
                        //    break;
                        //case 4:
                        //    p.WithDrawMoney();
                        //    break;
                        //case 5:
                        //default:
                        //    break;
                }
            }
            
            

        }
    }
}
