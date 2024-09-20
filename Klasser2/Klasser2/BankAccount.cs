using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser2
{
    internal class BankAccount
    {

        //Lägg till Egenskaper (fields)
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }


        //Lägg till Konstruktor
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        //Lägg till Metoder
        public void Deposit(double amount)//metod lägga till pengar
        {

            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Du har satt in: {amount}kr, ditt nya saldo är: {Balance}kr");
            }

            else//om användaren försöker sätta in ett negativt belopp
            {
                Console.WriteLine("Här kan du bara sätta in pengar");
            }
        }

        public void Withdraw(double amount)//metod för att ta ur pengar
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Du har tagit ut: {amount}kr, ditt nya belopp är: {Balance}kr");
            }

            else
            {
                Console.WriteLine($"Sorry, du försökte ta ut ett för stort belopp. Du har bara {Balance}kr på ditt konto");
            }
        }

        public void DisplayBalance()//metod för att kolla saldo
        { 
        Console.WriteLine($"Du har {Balance}kr kvar på kontot");
        }
    }
}
