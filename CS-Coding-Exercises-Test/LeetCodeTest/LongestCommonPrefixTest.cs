using LeetCode;

namespace LeetCodeTest.AddTwoNumbersTest;

[TestFixture]
public class LongestCommonPrefixTest
{
    [TestCase(new string[] { "flower", "flow", "flight" }, "fl")]
    [TestCase(new string[] { "dog", "racecar", "car" }, "")]
    public void Test(string[] strs, string longestPrefix)
    {
        Assert.That(LongestCommonPrefix.LongestCommonPrefixMethod(strs), Is.EqualTo(longestPrefix));        
    }        
}
