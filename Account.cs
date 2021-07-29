using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulationApp
{
    class Account
    {
        string accountHolderName;
        int accountNumber;
        DateTime accountCreationDate;
        double accountBalance;
        public enum AccountType
        {
            savings,
            current
        };
        AccountType aType;
        public string AccountHolderName { get => accountHolderName; set => accountHolderName = value; }
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public DateTime AccountCreationDate { get => accountCreationDate; set => accountCreationDate = value; }
        public double AccountBalance { get => accountBalance; set => accountBalance = value; }
        internal AccountType AType { get => aType; set => aType = value; }

        public Account()
        {
            AccountHolderName = null;
            AccountNumber = 0;
            accountCreationDate = DateTime.Now;
            AccountBalance = 0;
            AType = AccountType.savings;
        }

        public Account(string accName, int accNumber, DateTime accDate, double accBalance, int aType)
        {
            this.AccountHolderName = accName;
            this.AccountNumber = accNumber;
            this.AccountCreationDate = accDate;
            this.AccountBalance = accBalance;
            this.AType = (AccountType)aType;
            
        }
    }
}
//if((int)AccountType.savings == aType)
//{
//    this.AType = (AccountType)aType;
//    Console.WriteLine("Thanks for oepning a savings Account");
//}
//else
//{
//    this.AType = (AccountType)aType;
//    Console.WriteLine("Thanks for oepning a Current Account");
//}