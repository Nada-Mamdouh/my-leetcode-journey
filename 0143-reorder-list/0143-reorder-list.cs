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
    public void ReorderList(ListNode head) {
        if(head.next == null){
            return;
        }
        Stack<ListNode> otherHalf = new Stack<ListNode>();
        int listCount = 0;
        ListNode curr = head;
        while(curr != null){
            listCount++;
            curr = curr.next;
        }
        curr = head;
        for(int i = 0;i < listCount/2;i++){
            curr = curr.next;
        }
        ListNode mid = curr;

        while(curr != null){
            otherHalf.Push(curr);
            curr = curr.next;
        }
        curr = head;
        while(otherHalf.Count != 0){
            var tmpCurrent = curr.next;
            curr.next = otherHalf.Pop();
            curr.next.next = null;
            if(otherHalf.Count == 0) break;
            curr.next.next = tmpCurrent;
            curr = tmpCurrent;
        }
    }
}