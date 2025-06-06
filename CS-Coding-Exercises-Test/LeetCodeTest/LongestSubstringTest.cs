using LeetCode;

namespace LeetCodeTest.LongestSubstringTest;
[TestFixture]
public class LongestSubstringTest
{
    LongestSubstring longestSubstring;

    [SetUp]
    public void Setup()
    {
        longestSubstring = new LongestSubstring();
    }
    [Test]
    public void TestEmptyString()
    {
        Assert.That(longestSubstring.LengthOfLongestSubstring(""), Is.EqualTo(0));
    }

    [Test]
    public void TestSingleCharacter()
    {
        Assert.That(longestSubstring.LengthOfLongestSubstring("a"), Is.EqualTo(1));
    }

    [Test]
    public void TestMultipleCharactersWithoutRepetition()
    {
        Assert.That(longestSubstring.LengthOfLongestSubstring("abcde"), Is.EqualTo(5));
    }

    [Test]
    public void TestWithRepetition()
    {
        Assert.That(longestSubstring.LengthOfLongestSubstring("abcabcbb"), Is.EqualTo(3));
    }

    [Test]
    public void TestWithAllSameCharacters()
    {
        Assert.That(longestSubstring.LengthOfLongestSubstring("bbbb"), Is.EqualTo(1));
    }

    [Test]
    public void TestWithAllDifferentCharacters()
    {
        Assert.That(longestSubstring.LengthOfLongestSubstring("abcdefg"), Is.EqualTo(7));
    }

    [Test]
    public void MixedCharactersTest()
    {
        Assert.That(longestSubstring.LengthOfLongestSubstring("pwwkew"), Is.EqualTo(3));
    }
}
