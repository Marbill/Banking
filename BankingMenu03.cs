using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Banking.Ver01
{
    public partial class BankingMenu
    {
        public void CreateMutualFundsAccount()
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

            MutualFunds mf = new MutualFunds(0m, 0m, accountDate, firstName, lastName, birthDate, accountNumber);
            accountsDB.AddAccount(mf);
            accountsDB.Print(mf);
            WriteLine();
        }

        public void MutualFundsBalance(int actNumber)
        {
            WriteLine("1. Mutual Funds 1");
            WriteLine("2. Mutual Funds 2");
            int choice = Convert.ToInt32(ReadLine());
            switch (choice)
            {
                case 1:
                    WriteLine(accountsDB.Balance(actNumber, "mf1"));
                    WriteLine();
                    break;
                case 2:
                    WriteLine(accountsDB.Balance(actNumber, "mf2"));
                    WriteLine();
                    break;
                default:
                    WriteLine("Incorrect Input, Try Again...");
                    break;
            }
            MenuCustomer(actNumber);
        }

        public void MutualFundsDeposit(int actNumber)
        {
            WriteLine("1. Mutual Funds 1");
            WriteLine("2. Mutual Funds 2");
            int choice = Convert.ToInt32(ReadLine());
            switch (choice)
            {
                case 1:
                    WriteLine("Enter amount to deposit in Mutual Funds 1:");
                    decimal mf1Amount = Convert.ToDecimal(ReadLine());
                    WriteLine(accountsDB.Deposit(actNumber, "mf1", mf1Amount));
                    WriteLine();
                    break;
                case 2:
                    WriteLine("Enter amount to deposit in Mutual Funds 2:");
                    decimal mf2Amount = Convert.ToDecimal(ReadLine());
                    WriteLine(accountsDB.Deposit(actNumber, "mf2", mf2Amount));
                    WriteLine();
                    break;
                default:
                    WriteLine("Incorrect Input, Try Again...");
                    break;
            }
            MenuCustomer(actNumber);
        }

        public void MutualFundsWithdraw(int actNumber)
        {
            WriteLine("1. Mutual Funds 1");
            WriteLine("2. Mutual Funds 2");
            int choice = Convert.ToInt32(ReadLine());

            switch (choice)
            {
                case 1:
                    WriteLine("Enter amount to withdraw from Mutual Funds 1:");
                    decimal mf1Amount = Convert.ToDecimal(ReadLine());
                    WriteLine(accountsDB.Withdraw(actNumber, "mf1", mf1Amount));
                    WriteLine();
                    break;
                case 2:
                    WriteLine("Enter amount to withdraw from Mutual Funds 2:");
                    decimal mf2Amount = Convert.ToDecimal(ReadLine());
                    WriteLine(accountsDB.Withdraw(actNumber, "mf2", mf2Amount));
                    WriteLine();
                    break;
                default:
                    WriteLine("Incorrect Input, Try Again...");
                    break;
            }

            MenuCustomer(actNumber);
        }

    }
}
