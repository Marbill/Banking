using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Banking.Ver01
{
    public class AccountDB
    {
        List<Account> accountDB;


        public AccountDB()
        {
            accountDB = new List<Account>();

        }

        public void AddAccount(Account ac)
        {
            accountDB.Add(ac);

            WriteLine("Account Added.");

        }

        public void RemoveAccount(Account ac)
        {
            foreach (var account in accountDB)
            {
                if (ac.AccountNumber == account.AccountNumber)
                {
                    accountDB.Remove(ac);
                    WriteLine("Account Removed.");
                    return;
                }
            }

            WriteLine("Account Not Found.");
        }

        public void Print(Account ac)
        {
            foreach (var account in accountDB)
            {
                if (account.AccountNumber == ac.AccountNumber)
                {
                    ac.PrintAccount();
                    break;
                }
            }
        }

        public string Balance(int actNumber, string actType)
        {
            foreach (var account in accountDB)
            {
                if (account.AccountNumber == actNumber)
                {
                    return account.Balance(actType);
                }
            }

            return "Error.";
        }

        public string Deposit(int actNumber, string actType, decimal amount)
        {
            foreach (var account in accountDB)
            {
                if (account.AccountNumber == actNumber)
                {
                    return account.Deposit(actType, amount);
                }
            }

            return "Error.";
        }

        public string Withdraw(int actNumber, string actType, decimal amout)
        {
            foreach (var account in accountDB)
            {
                if (account.AccountNumber == actNumber)
                {
                    return account.Withdraw(actType, amout);
                }
            }

            return "Error.";
        }

        public int SearchAccount(int actNumber)
        {
            foreach (var account in accountDB)
            {
                if (account.AccountNumber == actNumber)
                {
                    return actNumber;
                }
            }

            return -1;
        }

        public string AccountType(int actNumber)
        {
            foreach (var account in accountDB)
            {
                if (account.AccountNumber == actNumber)
                {
                    return Convert.ToString(account.GetType());
                }
            }

            return $"null";
        }

    }
}
