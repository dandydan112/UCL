using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
       

        private string name;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        private double balance;
        public double Balance
        {
            get {  return balance;}
        }

        private bool locked;

        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }




        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public BankAccount(string name, double balance)
        {
            this.Name = name;
            this.balance= balance;
        }

        public BankAccount(string name, double balance, bool locked)
        {
            this.Name= name;
            this.balance= balance;
            this.locked = locked;
        }

        public override string ToString()
        {
                return ("Name: " + Name + ", Balance: " + balance);    
        }

        public void ChangeLockState()
        {
            if (locked == true)
            {
                locked = false;
            }
            else
            {
                locked = true;
            }

        }

        public void Withdraw(double amount)
        {
            if (locked == false && amount <= Balance)
            {
                balance -= amount;
            }
        }
        
        public void Deposit(double amount)
        {
            if (locked == false)
            {
                balance += amount;
            }
            
        }
        
    }
}
