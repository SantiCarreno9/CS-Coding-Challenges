using LeetCode;

namespace LeetCodeTest.AddTwoNumbersTest;

[TestFixture]
internal class RemoveDuplicatesTest
{
    [TestCase(new int[] { 1, 1, 2 }, new int[] { 1, 2, 2 }, 2)]
    [TestCase(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 }, 5)]
    public void Test(int[] nums, int[] expectedNums, int k)
    {
        Assert.That(RemoveDuplicates.RemoveDuplicatesInSortedArray(nums), Is.EqualTo(k));
        for (int i = 0; i < k; i++)
        {
            Assert.That(nums[i], Is.EqualTo(expectedNums[i]));
        }
    }
}
