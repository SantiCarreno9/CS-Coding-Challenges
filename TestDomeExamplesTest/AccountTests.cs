using TestDome;

namespace TestDomeExamplesTest.AccountTesting
{
    [TestFixture]
    public class AccountTests
    {

        [Test]
        public void DepositCannotAcceptNegativeAmounts()
        {
            Account account = new Account(0);
            Assert.AreEqual(false, account.Deposit(-20));
            Assert.AreEqual(false, account.Withdraw(-20));
        }

        [Test]
        public void WithdrawCannotAcceptNegativeAmounts()
        {
            Account account = new Account(0);
            account.Deposit(20);
            Assert.AreEqual(false, account.Withdraw(-20));
        }


        [Test]
        public void DepositCorrectAmount()
        {
            Account account = new Account(0);
            double amount = 20;
            account.Deposit(amount);
            Assert.AreEqual(amount, account.Balance);
        }

        [Test]
        public void WithdrawsCorrectAmount()
        {
            Account account = new Account(0);
            account.Deposit(20);
            account.Withdraw(5);
            double amount = 20 - 5;
            Assert.AreEqual(amount, account.Balance);
        }

        [Test]
        public void DepositAndWithdrawReturnsCorrectly()
        {
            Account account = new Account(0);            
            Assert.AreEqual(true, account.Deposit(20));
            Assert.AreEqual(true, account.Withdraw(5));
        }
    }
}