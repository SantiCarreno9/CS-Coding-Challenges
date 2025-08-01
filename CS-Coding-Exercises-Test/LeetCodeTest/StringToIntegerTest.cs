using LeetCode;

namespace LeetCodeTest.StringToIntegerTests;

internal class StringToIntegerTest
{
    private StringToInteger converter;

    [SetUp]
    public void SetUp()
    {
        this.converter = new StringToInteger();
    }

    [TestCase("42", 42)]
    [TestCase(" -042", -42)]
    [TestCase("1337c0d3", 1337)]
    [TestCase("0-1", 0)]
    [TestCase("words and 987", 0)]
    [TestCase("-91283472332", -2147483648)]
    [TestCase("3.14159", 3)]
    [TestCase("+-12", 0)]
    [TestCase("21474836460", 2147483647)]
    [TestCase("-2147483647", -2147483647)]
    public void TestCases(string s, int expected)
    {
        Assert.That(converter.MyAtoi(s), Is.EqualTo(expected));
    }
}
