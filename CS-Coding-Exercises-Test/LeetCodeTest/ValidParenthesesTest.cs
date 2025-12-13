using LeetCode;

namespace LeetCodeTest.AddTwoNumbersTest;

[TestFixture]
public class ValidParenthesesTest
{
    [TestCase("()", true)]    
    [TestCase("()[]{}", true)]    
    [TestCase("(]", false)]    
    [TestCase("([])", true)]    
    [TestCase("([)]", false)]    
    [TestCase("((", false)]    
    [TestCase("){", false)]    
    public void Test(string str, bool isValid)
    {
        Assert.That(ValidParentheses.IsValid(str), Is.EqualTo(isValid));        
    }        
}
