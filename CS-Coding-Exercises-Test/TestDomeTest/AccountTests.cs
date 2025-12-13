using TestDome;

namespace TestDomeTest
{
    [TestFixture]
    public class AccountTests
    {
        [Test]
        public void DepositCannotAcceptNegativeAmounts()
        {
            Account account = new Account(0);
            Assert.Equals(false, account.Deposit(-20));
            Assert.Equals(false, account.Withdraw(-20));
        }

        [Test]
        public void WithdrawCannotAcceptNegativeAmounts()
        {
            Account account = new Account(0);
            account.Deposit(20);
            Assert.Equals(false, account.Withdraw(-20));
        }


        [Test]
        public void DepositCorrectAmount()
        {
            Account account = new Account(0);
            double amount = 20;
            account.Deposit(amount);
            Assert.Equals(amount, account.Balance);
        }

        [Test]
        public void WithdrawsCorrectAmount()
        {
            Account account = new Account(0);
            account.Deposit(20);
            account.Withdraw(5);
            double amount = 20 - 5;
            Assert.Equals(amount, account.Balance);
        }

        [Test]
        public void DepositAndWithdrawReturnsCorrectly()
        {
            Account account = new Account(0);
            Assert.Equals(true, account.Deposit(20));
            Assert.Equals(true, account.Withdraw(5));
        }
    }
}