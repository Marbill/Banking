using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Banking.Ver01
{
    public class MutualFunds : Account
    {
        public MutualFunds(decimal mf1, decimal mf2, DateTime ad, string fn, string ln, DateTime bd, int an) : base(fn, ln, bd, an)
        {
            MutualFunds1 = mf1;
            MutualFunds2 = mf2;
            AccountDate = ad;
        }
        public DateTime AccountDate { get; set; }
        public decimal MutualFunds1 { get; set; }
        public decimal MutualFunds2 { get; set; }

        public override string Deposit(string accountType, decimal amount)
        {
            if (accountType == "mf1")
            {
                MutualFunds1 += amount;
                return $"Total Mutual Funds 1 balance: {MutualFunds1:C}";
            }
            else if (accountType == "mf2")
            {
                MutualFunds2 += amount;
                return $"Total Mutual Funds 2 balance: {MutualFunds2:C}";
            }
            else
            {
                return "Error...";
            }
        }

        public override string Withdraw(string accountType, decimal amount)
        {
            if (accountType == "mf1")
            {
                if (amount > MutualFunds1)
                {
                    return "Error, Not Enough Funds.";
                }
                else
                {
                    MutualFunds1 -= amount;
                    return $"Total Mutual Funds 1 balance: {MutualFunds1:C}";
                }
            }
            else if (accountType == "mf2")
            {
                if (amount > MutualFunds2)
                {
                    return "Error, Not Enough Funds.";
                }
                else
                {
                    MutualFunds2 -= amount;
                    return $"Total Mutual Funds 2 balance: {MutualFunds2:C}";
                }
            }
            else
            {
                return "Error.";
            }
        }

        public override string Balance(string accountType)
        {
            if (accountType == "mf1")
            {
                return $"Total Mutual Funds 1 balance: {MutualFunds1:C}";
            }
            else if (accountType == "mf2")
            {
                return $"Total Mutual Funds 2 balance: {MutualFunds2:C}";
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
            WriteLine($"Mutual Funds 1 Balance: {MutualFunds1}");
            WriteLine($"Mutual Funds 2 Balanace: {MutualFunds2}");
            WriteLine($"Account Date: {AccountDate:MMMM dd, yyyy}");
        }



    }
}
