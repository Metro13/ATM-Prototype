using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Machine_Prototype
{
    public partial class Form1 : Form
    {
        Account Account1, Account2, Account3, Account4, myAccount;

        private void CmdBalance_Click(object sender, EventArgs e)
        {       
                if (txtInputPad.Text == "")
                {

                    LblDisplay.Text = "Enter your Pin to Check Balance";
                }

                else
                {
                    if (int.Parse(txtInputPad.Text) == myAccount.Pin)
                    {
                        myAccount.CheckBalance();

                        LblDisplay.Text = "Your Balance is " + myAccount.Balance;
                    }
                    else
                    {
                        LblDisplay.Text = "No match for the pin";
                    }
                }
        }

        private void CmdC_Click(object sender, EventArgs e)
        {
            txtInputPad.Text = "";
        }

        private void CmdA_Click(object sender, EventArgs e)
        {
            Account selected;
            selected = GetAccount();

        }

        private void CmdWithdraw_Click(object sender, EventArgs e)
        {
            if (txtInputPad.Text == "")
            {
                LblDisplay.Text = "Enter the amount you want to withdraw";
               
            }

            else
            {
                if(int.Parse(txtInputPad.Text) < myAccount.Balance)
                {
                    myAccount.Withdraw(int.Parse(txtInputPad.Text));
                    LblDisplay.Text = "Withdrawal of " + txtInputPad.Text + ", was Successfull";
                }
                else 
                {
                    LblDisplay.Text = "Transaction failed! Balance insufficient'";
                }

            }
        }

        private void CmdReceiptWithdraw_Click(object sender, EventArgs e)
        {
            if (txtInputPad.Text == "")
            {
                LblDisplay.Text = "Enter the amount you want to withdraw";
            }

            else
            {
                if (int.Parse(txtInputPad.Text) < myAccount.Balance)
                {
                    myAccount.Withdraw(int.Parse(txtInputPad.Text));
                    
                    LblDisplay.Text = "You have withdrawed " + txtInputPad.Text + ", Account Name: " + myAccount.Realname + ", Account Number: " + myAccount.AccountNumber + ", The account is Balance is " + myAccount.Balance;
                }
                else
                {
                    LblDisplay.Text = "Transaction failed! Balance insufficient'";
                }

            }
        }

        private void CmdConfirm_Click(object sender, EventArgs e)
        {
           
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myAccount = new Account();


            ////Method Overloading ////

            Account1 = new Account("Noel Phiri", "001234", 1234, 80000);
            Account2 = new Account("James Mallen", "011234", 1223, 40000);
            Account3 = new Account("Janine Cody", "012243", 1233, 30000);
            Account4 = new Account("Patience Zuze", "012334", 1244, 60000);

            LblDisplay.Text = "Enter your Account Number";
        }

        

        private Account GetAccount()
        {
            Account RequiredAccount = new Account();

            myAccount.AccountNumber = txtInputPad.Text;

            if (myAccount.AccountNumber == "001234")
            {
                RequiredAccount = Account1;

                myAccount.Pin = RequiredAccount.Pin;
                myAccount.Balance = RequiredAccount.Balance;
                myAccount.Realname = RequiredAccount.Realname;
                myAccount.AccountNumber = RequiredAccount.AccountNumber;
            }
            else if (myAccount.AccountNumber == "011234")
            {
                RequiredAccount = Account2;
                myAccount.Pin = RequiredAccount.Pin;
                myAccount.Balance = RequiredAccount.Balance;
                myAccount.Realname = RequiredAccount.Realname;
                myAccount.AccountNumber = RequiredAccount.AccountNumber;

            }
            else if (myAccount.AccountNumber == "012243")
            {
                RequiredAccount = Account3;
                myAccount.Pin = RequiredAccount.Pin;
                myAccount.Balance = RequiredAccount.Balance;
                myAccount.Realname = RequiredAccount.Realname;
                myAccount.AccountNumber = RequiredAccount.AccountNumber;

            }
            else if (myAccount.AccountNumber == "012334")
            {
                RequiredAccount = Account4;
                myAccount.Pin = RequiredAccount.Pin;
                myAccount.Balance = RequiredAccount.Balance;
                myAccount.Realname = RequiredAccount.Realname;
                myAccount.AccountNumber = RequiredAccount.AccountNumber;

            }
            else
            {
                LblDisplay.Text = "No Account matched that Account Number";
            }

            LblDisplay.Text = "Select a transaction you want to perform";

            return RequiredAccount;
           
        }
    }
}
