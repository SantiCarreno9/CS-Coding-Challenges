using LeetCode;

namespace LeetCodeTest.AddTwoNumbersTest;

[TestFixture]
public class AddTwoNumbersTest
{
    AddTwoNumbers addTwoNumbers;

    [SetUp]
    public void Setup()
    {
        addTwoNumbers = new AddTwoNumbers();
    }
    [Test]
    public void TestOne()
    {
        var l1 = ListNode.CreateLinkedList(new int[] { 2, 4, 3 });
        var l2 = ListNode.CreateLinkedList(new int[] { 5, 6, 4 });
        Assert.That(addTwoNumbers.AddTwoNumber(l1, l2).Iterate().ToArray(), Is.EqualTo(new int[] { 7, 0, 8 }));
    }
    
    [Test]
    public void TestTwo()
    {
        var l1 = ListNode.CreateLinkedList(new int[] { 0 });
        var l2 = ListNode.CreateLinkedList(new int[] { 0 });
        Assert.That(addTwoNumbers.AddTwoNumber(l1, l2).Iterate().ToArray(), Is.EqualTo(new int[] { 0 }));
    }

    [Test]
    public void TestThree()
    {
        var l1 = ListNode.CreateLinkedList(new int[] { 9, 9, 9, 9, 9, 9, 9 });
        var l2 = ListNode.CreateLinkedList(new int[] { 9, 9, 9, 9 });
        Assert.That(addTwoNumbers.AddTwoNumber(l1, l2).Iterate().ToArray(), Is.EqualTo(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 }));
    }
}
