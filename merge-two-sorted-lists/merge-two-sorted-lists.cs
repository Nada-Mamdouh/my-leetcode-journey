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
        //Recursion solution:
        if(list1 == null && list2 == null || (list1 != null && list2 == null)) return list1;
        if(list1 == null && list2 != null) return list2;
        if(list1.val <= list2.val){
            ListNode tmp1 = list1.next;
            list1.next = MergeTwoLists(tmp1, list2);
            return list1;
        }else{
            ListNode tmp2 = list2.next;
            list2.next = MergeTwoLists(list1, tmp2);
            return list2;
        }
        
    }
}