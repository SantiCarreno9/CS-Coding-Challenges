using Misc.PalindromeChecker;

namespace MiscTest.PalindromeCheckerTest;

internal class PalindromeCheckerTest
{
    private PalindromeChecker checker;
    [SetUp]
    public void SetUp()
    {
        checker = new PalindromeChecker();
    }

    [TestCase("kayak", true)]
    [TestCase("madam", true)]
    [TestCase("123", false)]
    [TestCase("externocleidomaconretxe", false)]
    public void TestIsPalindrome(string word, bool expected)
    {
        Assert.That(checker.IsPalindrome(word), Is.EqualTo(expected));
    }
}
