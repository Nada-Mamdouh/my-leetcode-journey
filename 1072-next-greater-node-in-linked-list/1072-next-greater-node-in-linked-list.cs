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
    public int[] NextLargerNodes(ListNode head) {
        //TC: O(2n) + O(n) to get count + O(n) for converting list to array I guess
        //Sc: O(n) for stack + O(n) for returning answer
        if(head == null || head.next == null){
            return new int[] {0};
        }
        Stack<(int, int)> st = new();
        int n = GetCount(ref head);
        int[] ans = new int[n];
        ListNode curr = head;
        int i = 0;
        while(curr != null){           
            while(st.Count > 0 && curr.val > st.Peek().Item1){
                int idx = st.Peek().Item2;
                ans[idx] = curr.val;
                st.Pop();

            }
            st.Push((curr.val,i));
            curr = curr.next;
            i++;
        }
        return ans;  
    }
    int GetCount(ref ListNode head){
        int cntr = 0;
        ListNode curr = head;
        while(curr != null){
            cntr++;
            curr = curr.next;
        }
        return cntr;
    }
}