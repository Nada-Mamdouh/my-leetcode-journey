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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode newList = new ListNode();
        if(list1 == null) newList = list2;
        else if(list2 == null) newList = list1;
        else{
            ListNode curr1 =list1;
            ListNode curr2 = list2;
            ListNode curr3 = newList;
            if(curr1.val <= curr2.val){
                newList = curr1;
                curr1 = curr1.next;
            }else{
                newList = curr2;
                curr2 = curr2.next;
            }
            curr3 = newList;
            while(curr1 != null && curr2 != null){
                if(curr1.val < curr2.val){
                    curr3.next = curr1;
                    curr1 = curr1.next;
                }else{
                    curr3.next = curr2;
                    curr2 = curr2.next;
                }
                curr3 = curr3.next;
            }
            while(curr1 != null){
                curr3.next = curr1;
                curr1 = curr1.next;
                curr3 = curr3.next;
            }
            while(curr2 != null){
                curr3.next = curr2;
                curr2 = curr2.next;
                curr3 = curr3.next;
            }
        }
        return newList;
    }
}