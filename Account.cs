using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine_Prototype
{
    class Account
    {
        private string realname;
        private string accountNumber;
        private int pin;
        private int balance;

        // constructor 
        public Account(string realn, string accNum, int pin, int balance)
        {
            Realname = realn;
            AccountNumber = accNum;
            Pin = pin;
            Balance = balance;
        }

        public Account()
        {
            
        }

        // accessor function
        public string Realname
        {
            set
            {
                realname = value;
            }
            get
            {
                return realname;
            }
        }

        public string AccountNumber
        {
            set
            {
                accountNumber = value;
            }
            get
            {
                return accountNumber;
            }
        }

        public int Pin
        {
            set
            {
                pin = value;
            }

            get
            {
                return pin;
            }
        }

        public int Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }

        public void Withdraw(int amount)
        {
           Balance = Balance - amount;      
        }

        //checking acccount balance 
        public void CheckBalance()
        {      
             Balance = Balance;
        }
    }
}
