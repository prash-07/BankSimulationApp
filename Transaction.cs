using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulationApp
{
    class Transaction
    {
        int transactionID;
        string transactionType;
        int accountNumber;
        DateTime transactionDate;
        double transactionAmount;

        public int TransactionID { get => transactionID; set => transactionID = value; }
        public string TransactionType { get => transactionType; set => transactionType = value; }
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public double TransactionAmount { get => transactionAmount; set => transactionAmount = value; }
    }
}
