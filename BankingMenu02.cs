using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Banking.Ver01
{
    public partial class BankingMenu
    {

        public void SavingsBalance(int actNumber)
        {
            WriteLine("1. Savings");
            WriteLine("2. Checking");
            int choice = Convert.ToInt32(ReadLine());
            switch (choice)
            {
                case 1:
                    WriteLine(accountsDB.Balance(actNumber, "sav"));
                    WriteLine();
                    break;
                case 2:
                    WriteLine(accountsDB.Balance(actNumber, "chk"));
                    WriteLine();
                    break;
                default:
                    WriteLine("Incorrect Input, Try Again...");
                    break;
            }
            MenuCustomer(actNumber);
        }

        public void SavingsDeposit(int actNumber)
        {
            WriteLine("1. Savings");
            WriteLine("2. Checking");
            int choice = Convert.ToInt32(ReadLine());
            switch (choice)
            {
                case 1:
                    WriteLine("Enter amount to deposit in savings:");
                    decimal savAmount = Convert.ToDecimal(ReadLine());
                    WriteLine(accountsDB.Deposit(actNumber, "sav", savAmount));
                    WriteLine();
                    break;
                case 2:
                    WriteLine("Enter amount to deposit in checking:");
                    decimal chkAmount = Convert.ToDecimal(ReadLine());
                    WriteLine(accountsDB.Deposit(actNumber, "chk", chkAmount));
                    WriteLine();
                    break;
                default:
                    WriteLine("Incorrect Input, Try Again...");
                    break;
            }
            MenuCustomer(actNumber);
        }

        public void SavingsWithdraw(int actNumber)
        {
            WriteLine("1. Savings");
            WriteLine("2. Checking");
            int choice = Convert.ToInt32(ReadLine());

            switch (choice)
            {
                case 1:
                    WriteLine("Enter amount to withdraw from savings:");
                    decimal savAmount = Convert.ToDecimal(ReadLine());
                    WriteLine(accountsDB.Withdraw(actNumber, "sav", savAmount));
                    WriteLine();
                    break;
                case 2:
                    WriteLine("Enter amount to withdraw from checking:");
                    decimal chkAmount = Convert.ToDecimal(ReadLine());
                    WriteLine(accountsDB.Withdraw(actNumber, "chk", chkAmount));
                    WriteLine();
                    break;
                default:
                    WriteLine("Incorrect Input, Try Again...");
                    break;
            }

            MenuCustomer(actNumber);
        }

        public void CreateSavingsAccount()
        {
            WriteLine("Enter First Name:");
            string firstName = Convert.ToString(ReadLine());
            WriteLine("Enter Last Name:");
            string lastName = Convert.ToString(ReadLine());
            WriteLine("Enter Birth Date:");
            DateTime birthDate = Convert.ToDateTime(ReadLine());
            WriteLine("Enter Account Number:");
            int accountNumber = Convert.ToInt32(ReadLine());
            WriteLine("Enter Account Date:");
            DateTime accountDate = Convert.ToDateTime(ReadLine());

            BankAccount ba = new BankAccount(0m, 0m, accountDate, lastName, firstName, birthDate, accountNumber);
            accountsDB.AddAccount(ba);
            accountsDB.Print(ba);
            WriteLine();
        }




    }
}
