using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Type
{
    class Account
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string acNo;

        public string AcNo
        {
            get { return acNo; }
            set { accNo = value; }
        }
        protected double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account() { }
        public Account(string name,string accNo, double balance)
        {
            this.name = name;
            this.acNo = acNo;
            this.balance = balance;

        }
        virtual public void Deposit(double amount)
        {
            balance += amount;

        }
        virtual public void Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }
        virtual public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Account Number: " + acNo);
            Console.WriteLine("Balance : " + balance);
        }
        
    }
}