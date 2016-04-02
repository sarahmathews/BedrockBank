using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an instance of Account
            var account1 = new Account();
            account1.AccountName = "My Checking";
            account1.TypeOfAccount = AccountType.Checking;
            //account1.AccountNumber = 45566666;
            //account1.Balance = 1000000000000000000; 
            account1.Deposit(300.00);
            Console.WriteLine("Account Name: {0}, Number: {1}, Type of Account: {2}, Balance: {3:c}", account1.AccountName,
                account1.AccountNumber, account1.TypeOfAccount, account1.Balance);

            var account2 = new Account();
            account2.AccountName = "My Savings";
            account2.TypeOfAccount = AccountType.Savings;
            //account2.AccountNumber = 45566666;
            //account2.Balance = 1000000000000000000; 
            account2.Deposit(150.00);
            Console.WriteLine("Account Name: {0}, Number: {1}, Type of Account: {2}, Balance: {3:c}", account2.AccountName,
                account2.AccountNumber, account2.TypeOfAccount, account2.Balance);

        }
    }
}
