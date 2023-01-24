//------------------------------------------------------------------------------------------------------------------------
//You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, 
//and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
//You may assume the two numbers do not contain any leading zero, except the number 0 itself.
//------------------------------------------------------------------------------------------------------------------------

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var dummy = new ListNode(-1);
        var current = dummy;

        var carry = 0;
        while (l1 != null || l2 != null)
        {
            var value1 = l1 == null ? 0 : l1.val;
            var value2 = l2 == null ? 0 : l2.val;

            var sum = value1 + value2 + carry;
            carry = sum / 10;
            sum %= 10;
            current.next = new ListNode(sum);

            current = current.next;
            l1 = l1 == null ? null : l1.next;
            l2 = l2 == null ? null : l2.next;
        }

        if (carry != 0)
            current.next = new ListNode(carry);
        
        return dummy.next;
    }
}
