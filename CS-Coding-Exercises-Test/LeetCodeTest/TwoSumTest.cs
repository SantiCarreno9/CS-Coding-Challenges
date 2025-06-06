using LeetCode;

namespace LeetCodeTest.TwoSumTest;
[TestFixture]
public class TwoSumTest
{
    TwoSum twoSum;
    [SetUp]
    public void Setup()
    {
        twoSum = new TwoSum();
    }
    [Test]
    public void TestOne()
    {
        Assert.That(twoSum.TwoSums(new int[] { 2, 7, 11, 15 }, 9), Is.EqualTo(new int[] { 0, 1 }));
    }

    [Test]
    public void TestTwo()
    {
        Assert.That(twoSum.TwoSums(new int[] { 3, 2, 4 }, 6), Is.EqualTo(new int[] { 1, 2 }));
    }

    [Test]
    public void TestThree()
    {
        Assert.That(twoSum.TwoSums(new int[] { 3, 3 }, 6), Is.EqualTo(new int[] { 0, 1 }));
    }
}
