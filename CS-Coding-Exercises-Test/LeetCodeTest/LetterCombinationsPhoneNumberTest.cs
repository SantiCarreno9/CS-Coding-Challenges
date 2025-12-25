using LeetCode;

namespace LeetCodeTest;

[TestFixture]
internal class LetterCombinationsPhoneNumberTest
{
    private bool TestMethod(string digits, List<string> expectedCombinations)
    {
        IList<string> actualCombinations = LetterCombinationsPhoneNumber.LetterCombinations(digits);
        if (actualCombinations.Count != expectedCombinations.Count)
            return false;
        for (int i = 0; i < expectedCombinations.Count; i++)
        {
            if (actualCombinations[i] != expectedCombinations[i])
                return false;
        }
        return true;
    }

    [Test]
    public void TestOne()
    {
        var digits = "23";
        var expectedCombinations = new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
        Assert.That(TestMethod(digits, expectedCombinations), Is.True);
    }

    
    [Test]
    public void TestTwo()
    {
        var digits = "2";
        var expectedCombinations = new List<string> { "a", "b", "c" };
        Assert.That(TestMethod(digits, expectedCombinations), Is.True);
    }

    [Test]
    public void TestThree()
    {
        var digits = "234";
        var expectedCombinations = new List<string> { "adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", "bdg", "bdh", "bdi", "beg", "beh", "bei", "bfg", "bfh", "bfi", "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi" };
        Assert.That(TestMethod(digits, expectedCombinations), Is.True);
    }
}
