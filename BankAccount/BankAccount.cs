using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }


        //Lägg till Konstruktor
        public BankAccount(int accountNumber, string accountHolder, double balance) 
        {
            AccountNumber= accountNumber;
            AccountHolder= accountHolder;
            Balance= balance;
        }

        //Lägg till Metoder
        public double Deposit()//metod lägga till pengar
        { 
        
        }

        public double Withdraw()//metod för att ta ur pengar
        { 
        
        }

        public double DisplayBalance()//metod för att kolla saldo
        { 
        
        }
    }
}
