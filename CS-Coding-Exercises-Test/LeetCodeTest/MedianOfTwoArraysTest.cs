using LeetCode;

namespace LeetCodeTest.MedianOfTwoArraysTest;

[TestFixture]
public class MedianOfTwoArraysTest
{
    MedianOfTwoArrays medianOfTwoArrays;

    [SetUp]
    public void Setup()
    {
        medianOfTwoArrays = new MedianOfTwoArrays();
    }

    [Test]
    public void TestSingleElementArrays()
    {
        Assert.That(medianOfTwoArrays.FindMedianSortedArrays(new int[] { 1 }, new int[] { 2 }), Is.EqualTo(1.5));
    }

    [Test]
    public void TestUnequalLengthArrays()
    {
        Assert.That(medianOfTwoArrays.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }), Is.EqualTo(2.0));
    }

    [Test]
    public void TestEqualLengthArrays()
    {
        Assert.That(medianOfTwoArrays.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 }), Is.EqualTo(2.5));
    }
}
