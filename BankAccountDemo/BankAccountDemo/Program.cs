using System;

namespace BankAccountDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class BankAccount
    {
        double balance;
        string CustName;

        public BankAccount(double balance, string custName)
        {
            this.balance = balance;
            CustName = custName;
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }

        }
        public string Customer
        {
            get
            {
                return CustName;
            }
            set
            {
                CustName = value;
            }

        }
        public double deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
        public double withdraw(double amount)
        {
            Balance -= amount;
            return Balance;

        }
        public double Calcinterest(double amount)
        {
            //double interest=2;
            
            Balance = Balance * (amount %100);
            return Balance;

        }

    }
}
