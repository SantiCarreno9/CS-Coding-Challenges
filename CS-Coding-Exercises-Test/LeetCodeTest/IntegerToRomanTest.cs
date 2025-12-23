using LeetCode;
namespace LeetCodeTest.IntegerToRomanTest;

[TestFixture]
internal class IntegerToRomanTest
{
    IntegerToRoman integerToRoman;

    [SetUp]
    public void Setup()
    {
        integerToRoman = new IntegerToRoman();
    }

    [Test]
    public void IntToRoman_Example1_ReturnsMMMDCCXLIX()
    {        
        string result = integerToRoman.IntToRoman(3749);
        Assert.That(result, Is.EqualTo("MMMDCCXLIX"));
    }

    [Test]
    public void IntToRoman_Example2_ReturnsLVIII()
    {
        string result = integerToRoman.IntToRoman(58);
        Assert.That(result, Is.EqualTo("LVIII"));
    }

    [Test]
    public void IntToRoman_Example3_ReturnsMCMXCIV()
    {
        string result = integerToRoman.IntToRoman(1994);
        Assert.That(result, Is.EqualTo("MCMXCIV"));
    }

}
