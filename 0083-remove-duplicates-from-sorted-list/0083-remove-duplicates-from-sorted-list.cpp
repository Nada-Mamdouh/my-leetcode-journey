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
    ListNode* deleteDuplicates(ListNode* head) {
        Remove(head);
        return head;
    }
    void Remove(ListNode* curr){
        if(curr == nullptr) return;
        while(curr -> next != nullptr && curr -> val == curr -> next -> val) {
            curr -> next = curr -> next -> next;
        }
        Remove(curr -> next);
    }
};