using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    
    public class BankAccount
    {
        private decimal amount = 0;
        private string name;

        public BankAccount(decimal amount, string name)
        {
            this.Amount = amount;
        }


        public decimal Amount
        {
            get => amount;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No negatives");

                }

                amount = value;
            }
        }

        public void Deposit(decimal amountForDeposit)
        {
            Amount += amountForDeposit;
        }
    }
}
