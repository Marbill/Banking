using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Banking.Ver01
{
    public partial class BankingMenu
    {
        AccountDB accountsDB = new AccountDB();
        private readonly int admin = 0101;

        public void MasterMenu()
        {

            WriteLine("Enter Password:");
            int choice = Convert.ToInt32(ReadLine());


            while (choice != 3)
            {
                switch (Authentication(choice))
                {
                    case 1:
                        MenuAdministrator();
                        break;
                    case 2:
                        MenuCustomer(choice);
                        break;
                    default:
                        WriteLine("Incorrect Password - Try Again.");
                        break;
                }

                MasterMenu();
            }
        }

        public void MenuAdministrator()
        {
            WriteLine("1. Create New Account");
            WriteLine("2. Exit");
            int choice = Convert.ToInt32(ReadLine());

            switch (choice)
            {
                case 1:
                    MenuAccountType();
                    break;
                case 2:
                    MasterMenu();
                    break;
                default:
                    break;
            }
            MenuAdministrator();
        }

        public void MenuCustomer(int actNumber)
        {
            if (accountsDB.AccountType(actNumber) == "Banking.Ver01.BankAccount")
            {
                WriteLine("Checking and Savings Account System");
                WriteLine("1. Balance");
                WriteLine("2. Deposit");
                WriteLine("3. Withdraw");
                WriteLine("4. Exit");
                int choice = Convert.ToInt32(ReadLine());

                switch (choice)
                {
                    case 1:
                        SavingsBalance(actNumber);
                        break;
                    case 2:
                        SavingsDeposit(actNumber);
                        break;
                    case 3:
                        SavingsWithdraw(actNumber);
                        break;
                    case 4:
                        MasterMenu();
                        break;
                    default:
                        break;
                }
            }
            else if (accountsDB.AccountType(actNumber) == "Banking.Ver01.MutualFunds")
            {
                WriteLine("Mutual Funds Account System");
                WriteLine("1. Balance");
                WriteLine("2. Deposit");
                WriteLine("3. Withdraw");
                WriteLine("4. Exit");
                int choice = Convert.ToInt32(ReadLine());

                switch (choice)
                {
                    case 1:
                        MutualFundsBalance(actNumber);
                        break;
                    case 2:
                        MutualFundsDeposit(actNumber);
                        break;
                    case 3:
                        MutualFundsWithdraw(actNumber);
                        break;
                    case 4:
                        MasterMenu();
                        break;
                    default:
                        break;
                }


            }
        }

        public void MenuAccountType()
        {
            WriteLine("1. Bank Account");
            WriteLine("2. Mutual Funds");
            int choice = Convert.ToInt32(ReadLine());

            switch (choice)
            {
                case 1:
                    CreateNewAccount(1);
                    break;
                case 2:
                    CreateNewAccount(2);
                    break;
                default:
                    WriteLine("Wrong Input, Try Again...");
                    break;
            }
            MenuAccountType();
        }

        public void CreateNewAccount(int actType)
        {
            if (actType == 1)
            {
                CreateSavingsAccount();
            }
            else if (actType == 2)
            {
                CreateMutualFundsAccount();
            }
            MenuAdministrator();
        }

        public int Authentication(int password)
        {
            if (password == admin)
            {
                return 1;
            }
            else if (accountsDB.SearchAccount(password) != -1)
            {
                return 2;
            }

            return -1;
        }

    }
}
