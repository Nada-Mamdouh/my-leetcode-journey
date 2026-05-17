/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* removeElements(ListNode* head, int val) {
        ListNode* curr = new ListNode();
        curr -> next = head;
        Remove(curr, val);
        return curr -> next;
    }
    void Remove(ListNode* curr, int val){
        if(curr == nullptr) return;
        while(curr != nullptr && curr -> next != nullptr && curr -> next -> val == val){
            curr -> next = curr -> next -> next;
        }
        Remove(curr -> next, val);
    }
};