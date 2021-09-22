using Bank;
using NUnit.Framework;
using System;

namespace BankTests
{
    [TestFixture]
    public class BankAcountTests
    {
        private decimal amount;
        private string name;
        private BankAccount bankAccount;
        private decimal amountForDeposit;

        [SetUp]

        public void SetUp()
        {
            this.name = "Pesho";
            this.amount = 5;
            this.bankAccount = new BankAccount(this.amount, this.name);
            this.amountForDeposit = 10;

        }
        [Test]

        public void WhenAcountInicializedWithPositiveValue_AmountShoulBeChanged()
        {
            
            Assert.That(bankAccount.Amount, Is.EqualTo(amount));
        }

        [Test]

        public void WhenAccountDeposit_IsMade_SholudBeChangeAmount()
        {

            bankAccount.Deposit(amountForDeposit);
            Assert.That(bankAccount.Amount, Is.EqualTo(amount + amountForDeposit));

        }
    }
}
