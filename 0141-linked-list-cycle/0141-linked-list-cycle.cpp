/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    unordered_set<ListNode* > sett;
    bool hasCycle(ListNode *head) {
        if(head == nullptr || head -> next == nullptr) return false;
        if(sett.contains(head)) return true;
        sett.insert(head);
        return hasCycle(head -> next);
    }
};