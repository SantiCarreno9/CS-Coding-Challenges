using LeetCode;

namespace LeetCodeTest.PalindromeNumberTests;

public class PalindromeNumberTest
{
    PalindromeNumber checker;

    [SetUp]
    public void Setup()
    {
        checker = new PalindromeNumber();
    }

    [TestCase(121, true)]
    [TestCase(-121, false)]
    [TestCase(10, false)]
    [TestCase(0, true)]
    [TestCase(11, true)]
    public void TestIsPalindrome(int number, bool expected)
    {
        Assert.That(checker.IsPalindrome(number), Is.EqualTo(expected));
    }

}
