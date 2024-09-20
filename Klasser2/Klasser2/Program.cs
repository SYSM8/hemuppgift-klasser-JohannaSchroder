using System;
using System.Collections.Generic;
using System.Linq;

namespace Klasser2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BankAccount account = new BankAccount("123456789", "John Doe", 1000);
            account.Deposit(500);
            account.Withdraw(200);
            account.DisplayBalance();
        }
    }
}
