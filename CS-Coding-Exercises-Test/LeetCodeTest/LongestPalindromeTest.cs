using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.LongestPalindromeTests;

internal class LongestPalindromeTest
{
    private LongestPalindromeSearcher longestPalindromeSearcher;

    [SetUp]
    public void SetUp()
    {
        longestPalindromeSearcher = new LongestPalindromeSearcher();
    }

    //[TestCase("babad", "aba")]
    [TestCase("babad", "bab")]    
    [TestCase("cbbd", "bb")]
    [TestCase("cbbdaba", "aba")]
    [TestCase("bbc", "bb")]
    [TestCase("bb", "bb")]
    [TestCase("abbcccbbbcaaccbababcbcabca", "bbcccbb")]
    public void TestOne(string word, string longestPalindrome)
    {
        Assert.That(longestPalindromeSearcher.LongestPalindrome(word), Is.EqualTo(longestPalindrome));
    }
}
