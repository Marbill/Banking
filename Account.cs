using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Ver01
{
    public class Account
    {
        public Account(string fn, string ln, DateTime bd, int an)
        {
            FirstName = fn;
            LastName = ln;
            BirthDate = bd;
            AccountNumber = an;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public int AccountNumber { get; private set; }

        public virtual string Balance(string aType)
        {
            return "base balance";
        }

        public virtual void PrintAccount()
        {
        }

        public virtual string Deposit(string aType, decimal amount)
        {
            return $"base deposit";
        }

        public virtual string Withdraw(string aType, decimal amount)
        {
            return $"base withdraw";
        }

    }
}
