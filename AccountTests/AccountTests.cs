using NUnit.Framework;
using System;
using ShortConsoleApplications;

namespace AccountTests
{

    /*
     * Using only NUnit's Assert.AreEqual method, write tests for the Account class that cover the following cases:

    The Deposit and Withdraw methods will not accept negative numbers.
    Account cannot overstep its overdraft limit.
    The Deposit and Withdraw methods will deposit or withdraw the correct amount, respectively.
    The Withdraw and Deposit methods return the correct results.
    */

    [TestFixture]
    public class AccountTests
    {

        private double epsilon = 1e-6;

        [Test]
        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            Account account = new Account(-20);

            Assert.AreEqual(0, account.OverdraftLimit, epsilon);
        }

        [Test]
        public void WithdrawDepositDoesntAcceptNegativeNumbers()
        {
            Account account = new Account(20);

            Assert.AreEqual(account.Deposit(-2.0), false);
            Assert.AreEqual(account.Withdraw(-2.0), false);
        }

        [Test]
        public void AccountCannotOverstepOverdraftLimit()
        {
            Account account = new Account(20);

            Assert.AreEqual(account.Withdraw(30), false);
        }

        [Test]
        public void WithdrawDepositDoTheCorrectAmmountRespectively()
        {
            Account account = new Account(20);

            account.Deposit(3.0);
            Assert.AreEqual(account.Balance, 3.0);
            account.Withdraw(2.0);
            Assert.AreEqual(account.Balance, 1.0);
        }

        [Test]
        public void WithdrawDepositReturnCorrectResults()
        {
            Account account = new Account(20);

            Assert.AreEqual(account.Deposit(5), true);
            Assert.AreEqual(account.Withdraw(3), true);
        }
    }
}
