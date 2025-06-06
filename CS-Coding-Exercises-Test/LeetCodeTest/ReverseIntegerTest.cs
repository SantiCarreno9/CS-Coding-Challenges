using LeetCode;

namespace LeetCodeTest.ReverseIntegerTest;
[TestFixture]
public class ReverseIntegerTest
{
    ReverseInteger reverseInteger;
    [SetUp]
    public void Setup()
    {
        reverseInteger = new ReverseInteger();
    }
    [Test]
    public void TestPositive()
    {
        Assert.That(reverseInteger.Reverse(123), Is.EqualTo(321));
    }

    [Test]
    public void TestNegative()
    {
        Assert.That(reverseInteger.Reverse(-123), Is.EqualTo(-321));
    }

    [Test]
    public void TestZerosInMiddle()
    {
        Assert.That(reverseInteger.Reverse(901000), Is.EqualTo(109));
    }

    [Test]
    public void TestOutOfRangePositive()
    {
        Assert.That(reverseInteger.Reverse(1233456789), Is.EqualTo(0));
    }

    [Test]
    public void TestOutOfRangeNegative()
    {
        Assert.That(reverseInteger.Reverse(-1233456789), Is.EqualTo(0));
    }
}
