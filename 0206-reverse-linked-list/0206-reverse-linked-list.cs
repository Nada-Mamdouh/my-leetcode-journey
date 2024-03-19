/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        // 1- Iterative approach:
        // O(n) Time Complexity, O(1) space Complexity
            if (head == null || head.next == null) return head;

            ListNode prev = null;
            ListNode curr = head;
            ListNode forward = head.next;

            while (forward != null) { 
                    curr.next = prev;
                    prev = curr;
                    curr = forward;
                    forward = forward.next;
                }
                curr.next = prev;
                head = curr;
                return head;
    }
}