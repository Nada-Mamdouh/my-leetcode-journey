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
        return rev(null, head);
    }
    public ListNode rev(ListNode prev, ListNode curr){
        if(curr == null) return prev;
        ListNode tmp = curr.next;
        curr.next = prev;
        return rev(curr, tmp);
    }
}