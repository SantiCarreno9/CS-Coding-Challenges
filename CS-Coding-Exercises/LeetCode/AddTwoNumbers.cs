/*
 You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example 1:

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
 */

namespace LeetCode;


//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public IEnumerable<int> Iterate()
    {
        var node = this;
        while (node != null)
        {
            yield return node.val;
            node = node.next;
        }
    }

    public void PrintList()
    {
        foreach (var item in this.Iterate())
        {
            Console.Write($"{item},");
        }
    }

    public static ListNode CreateLinkedList(int[] array)
    {
        ListNode listNode = new ListNode();
        var node = listNode;
        int counter = 0;
        while (true)
        {
            node.val = array[counter];
            counter++;
            if (counter == array.Length)
                break;

            if (node.next == null)
                node.next = new ListNode();
            node = node.next;
        }
        return listNode;
    }
}


public class AddTwoNumbers
{

    public ListNode AddTwoNumber(ListNode l1, ListNode l2)
    {
        var result = new ListNode();
        var n1 = l1;
        var n2 = l2;
        var n3 = result;
        while (n1 != null || n2 != null)
        {
            if (n1 != null)
            {
                n3.val += n1.val;
                n1 = n1.next;
            }

            if (n2 != null)
            {
                n3.val += n2.val;
                n2 = n2.next;
            }
            int nextNodeInitialValue = (n3.val > 9) ? (n3.val / 10) : 0;
            if (nextNodeInitialValue > 0)
                n3.val = n3.val - (nextNodeInitialValue * 10);
            if (n1 != null || n2 != null || nextNodeInitialValue > 0)
            {
                n3.next = new ListNode(nextNodeInitialValue);
                n3 = n3.next;
            }
        }
        return result;
    }
}
