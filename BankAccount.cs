using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Constructors_Methods_Overloading_JuanHernandez
{
    public class BankAccount
    {
        // Fields
        string _accountNumber;
        string _customerName;
        double _balance;

        // Properties
        public string AccountNumber { get => _accountNumber;}
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public double Balance { get => _balance;}

        public BankAccount(string accountnumber, string customername, double balance) 
        { 
            _accountNumber = accountnumber;
            CustomerName = customername;    
            _balance = balance;
        }

        public void Deposit(double amount) // deposit method
        {
            if (amount <= 0) // validation
            {
                Console.WriteLine("Sorry cant deposit 0 or negative amount."); // display if 0 or negative
            }
            else
            {
                _balance += amount;
            }
        }
        public void Withdraw(double amount) // withdraw method
        {
            if (amount <= 0 || amount > _balance) // validation
            {
                Console.WriteLine("Sorry, amount is greater than your balance or you cant withdraw negative amount.");
            }
            else
            {
                _balance -= amount; 
            }
        }
        public override string ToString() // ToString Overide
        {
            return $"{AccountNumber} - {CustomerName} - Current Balance: {Balance.ToString("c")}";
        }
    }
}
