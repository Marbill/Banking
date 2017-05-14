using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Banking.Ver01
{
    public class BankAccount : Account
    {
        public BankAccount(decimal chk, decimal sav, DateTime ad, string ln, string fn, DateTime bd, int an) : base(fn, ln, bd, an)
        {
            AccountDate = ad;
            Checking = chk;
            Savings = Savings;
        }

        public DateTime AccountDate { get; set; }
        public decimal Checking { get; set; }
        public decimal Savings { get; set; }

        public override string Deposit(string accountType, decimal amount)
        {
            if (accountType == "sav")
            {
                Savings += amount;
                return $"Total savings balance: {Savings:C}";
            }
            else if (accountType == "chk")
            {
                Checking += amount;
                return $"Total checking balance: {Checking:C}";
            }
            else
            {
                return "Error...";
            }
        }

        public override string Withdraw(string accountType, decimal amount)
        {
            if (accountType == "sav")
            {
                if (amount > Savings)
                {
                    return "Error, Not Enough Funds.";
                }
                else
                {
                    Savings -= amount;
                    return $"Total savings balance: {Savings:C}";
                }
            }
            else if (accountType == "chk")
            {
                if (amount > Checking)
                {
                    return "Error, Not Enough Funds.";
                }
                else
                {
                    Checking -= amount;
                    return $"Total checking balance: {Checking:C}";
                }
            }
            else
            {
                return "Error.";
            }
        }

        public override string Balance(string accountType)
        {
            if (accountType == "sav")
            {
                return $"Total savings balance: {Savings:C}";
            }
            else if (accountType == "chk")
            {
                return $"Total checking balance: {Checking:C}";
            }
            else
            {
                return "Error.";
            }
        }

        public override void PrintAccount()
        {
            WriteLine($"Last Name: {LastName}");
            WriteLine($"First Name: {FirstName}");
            WriteLine($"Birth Date: {BirthDate:MMMM dd, yyyy}");
            WriteLine($"Account Number: {AccountNumber}");
            WriteLine($"Savings Balance: {Savings:C}");
            WriteLine($"Checking Balanace: {Checking:C}");
            WriteLine($"Account Date: {AccountDate:MMMM dd, yyyy}");
        }
    }
}
